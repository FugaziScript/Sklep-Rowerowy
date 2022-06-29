using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Projekt_PO {
    public partial class koszyk_GUI : Form {
        private GUI AppGUI;
        private Koszyk koszyk = null;
        private int OldValue; //Bufor dla starej ilości
        private bool SelectionBlocked=false;
        private int SelectedColumn = 0;
        private int SelectedRow = 0;
        public koszyk_GUI(GUI AppGUI, Koszyk koszyk, bool display = false) {
            if (AppGUI == null) {
                throw new Exception("AppGUI nie może być null!");
            }
            if (koszyk == null) {
                throw new Exception("Koszyk nie może być null!");
            }
            this.Location = AppGUI.Location;
            this.AppGUI = AppGUI;
            this.koszyk = koszyk;
            this.MaximizeBox = false; //Nie można maksymalizować okna
            this.MinimizeBox = false; //Nie można minimalizować okna
            InitializeComponent(); //Zmodyfikowan w celu zablokowania możliwości dodawania kolumn i wierszy.
            //Ustawiamy kolor tła tabeli i formularza na biały
            this.koszyk_zawartosc_lista.BackgroundColor = Color.White;
            this.BackColor = Color.White;
            //Blokada możliwości zaznaczenia wielu pól na raz
            this.koszyk_zawartosc_lista.MultiSelect = false;
            //Usuwamy granice z tabeli koszyka
            this.koszyk_zawartosc_lista.BorderStyle = BorderStyle.None;
            if (display == true) {
                this.Visible = true;
                this.Wyswietl();
            }
        }
        public void Wyswietl() {
            koszyk_zawartosc_lista.Rows.Clear();
            this.SelectionBlocked = false; //Odblokowanie możliwości wyboru
            List<ZawartoscLst> lista = Convert2Struct(koszyk.PobierzZawartoscIItem());
            int LP = 1; //Liczba porządkowa liczona od 1.
            double TempWartosc = 0; //Tymczasowa cena
            double TempCena = 0;
            int TempIlosc = 0;
            foreach (ZawartoscLst przedmiot in lista) {
                koszyk_zawartosc_lista.Rows.Add(
                    (LP.ToString() + "."), //Nr. porządkowy
                    przedmiot.element.Nazwa, //Nazwa
                    przedmiot.ilosc.ToString(), //Ilość
                    przedmiot.element.Cena.ToString(), //Cena
                    (przedmiot.ilosc * przedmiot.element.Cena).ToString(), //Wartość
                    przedmiot.element.ID); //ID, pole niewidoczne, używane do identyfikacji obiektu
                LP++; //Zwiększamy liczbę porządkową z każdym elementem.
                TempWartosc += (przedmiot.ilosc * przedmiot.element.Cena);
                TempCena += przedmiot.element.Cena;
                TempIlosc += przedmiot.ilosc;
            }
            //Podsumowanie
            koszyk_zawartosc_lista.Rows.Add(
                                            "",
                                            "Suma:",
                                            TempIlosc.ToString(),
                                            TempCena.ToString(),
                                            TempWartosc.ToString());
            //Dla czytelności na czerwono
            for (int i = 0; i < koszyk_zawartosc_lista.Rows[0].Cells.Count; i++) {
                koszyk_zawartosc_lista.Rows[koszyk_zawartosc_lista.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Red;
            }

        }
        public void DokonanoZakupu(double cena) {
            MessageBox.Show("Produkty w koszyku zostały zakupione. Całowita wartość zakupionych produktów: "+cena.ToString()+" zł.");
        }
        private void koszyk_button_wyczysc_Click(object sender, EventArgs e) {
            if (koszyk != null) {
                koszyk.Wyczysc();
            }
        }
        private void koszyk_button_kup_Click(object sender, EventArgs e) {
            if (koszyk != null) {
                koszyk.Kup();
            }
        }
        //Zapisujemy starą wartość do bufora
        private void DGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            this.SelectionBlocked = true;
            this.SelectedColumn = e.ColumnIndex;
            this.SelectedRow = e.RowIndex;
            if (DGV_not_restricted(e.ColumnIndex, e.RowIndex)) {
                if (IntParse(koszyk_zawartosc_lista[e.ColumnIndex, e.RowIndex].Value.ToString(), ref this.OldValue) == false) {
                    koszyk_zawartosc_lista[e.ColumnIndex, e.RowIndex].Value = OldValue;
                }
            }
        }
        //Zamiana ilości w formularzu
        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (DGV_not_restricted(e.ColumnIndex, e.RowIndex)) {
                int NewValue = 0;
                int MaxValue = 0;
                int TempID = 0;
                int kolumna = 5; //ID w 5. kolunie
                int rzad = e.RowIndex;
                //Pobieramy ID produktu, aby sprawdzić wartość maksymalną
                Int32.TryParse(koszyk_zawartosc_lista[kolumna, rzad].Value.ToString(), out TempID);
                Console.WriteLine(koszyk_zawartosc_lista[kolumna, rzad].Value.ToString());
                //Szukamy maksymalnej ilości produktów o zadanym ID
                MaxValue = GetQuantity(TempID);
                if (IntParse(koszyk_zawartosc_lista[e.ColumnIndex, e.RowIndex].Value.ToString(), ref NewValue, MaxValue) == false) {
                    koszyk_zawartosc_lista[e.ColumnIndex, e.RowIndex].Value = OldValue;
                } else {
                    koszyk_zawartosc_lista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = NewValue;
                }
                OldValue = GetCount(TempID);
                int roznica = NewValue - OldValue;
                koszyk.value_update_GUI(this, TempID, roznica);
            }
            try {
                this.Wyswietl();
            }catch(Exception exc) {
                Debug.WriteLine(exc.Message);
            }
        }
        //Blokada zmiany zaznaczenia komórki
        private void DGV_SelectionChanged(Object sender, EventArgs e) {
            if (SelectionBlocked == true) {
                this.koszyk_zawartosc_lista[SelectedColumn, SelectedRow].Selected = true;
            }
        }
        private void koszyk_GUI_FormClosing(object sender, FormClosingEventArgs e) {
            //Okno koszyka nie ma być zamykane, tylko chowane.
            this.Visible = false;
            e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
