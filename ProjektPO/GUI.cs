using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PO
{
    public partial class GUI : Form
    {
        private bool KreatorOn { get; set; } = false;
        private string Szukana { get; set; } = "";
        private FormDodawanie fd = new FormDodawanie();

        public GUI()
        {
            InitializeComponent();
            listView_container.View = View.Details;
            listView_container.FullRowSelect = true;
            listView_container.GridLines = true;
            this.koszyk = null;
        }

        private void DodajBazowe()
        {
            listView_container.Clear();
            listView_container.Columns.Add("ID", 40);
            listView_container.Columns.Add("Nazwa", 120);
            listView_container.Columns.Add("Producent", 70);
            listView_container.Columns.Add("Cena", 60); //Było 40
            listView_container.Columns.Add("Ilosc", 40);
        }

        private void Szukaj(IItem obj)
        {
            foreach (var s in obj.Wypisz())
            {
                if (s.Contains(Szukana))
                {
                    listView_container.Items.Add(new ListViewItem(obj.Wypisz().ToArray()));
                    break;
                }
            }
        }

        private void ZaladujDane()
        {
            List<IItem> przedmioty = DataSourceSQL.Instance.WczytajDane();
            switch (treeView_kategorie.SelectedNode.Name)
            {
                case "Przedmioty":
                    DodajBazowe();

                    foreach (var r in przedmioty)
                    {
                        Szukaj(r);
                    }
                    break;

                //==========================CZESCI=========================

                case "Czesci":
                    DodajBazowe();

                    foreach (var r in przedmioty)
                    {
                        if (r is Czesci)
                            Szukaj(r);
                    }
                    break;

                case "Ramy":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Typ", 60);
                    listView_container.Columns.Add("Materiał", 80);
                    listView_container.Columns.Add("Rozmiar", 60);
                    listView_container.Columns.Add("Waga [kg]", 50);
                    listView_container.Columns.Add("Średnica Sztycy", 110);
                    listView_container.Columns.Add("Rozmiar Koła", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Rama)
                            Szukaj(r);
                    }
                    break;

                case "Kierownice":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Typ", 80);
                    listView_container.Columns.Add("Materiał", 80);
                    listView_container.Columns.Add("Szerokość [cm]", 100);

                    foreach (var r in przedmioty)
                    {
                        if (r is Kierownica)
                            Szukaj(r);
                    }
                    break;

                case "Siodelka":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Płeć", 80);
                    listView_container.Columns.Add("Typ", 80);
                    listView_container.Columns.Add("Materiał", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Siodelko)
                            Szukaj(r);
                    }
                    break;

                case "Kola":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Materiał", 80);
                    listView_container.Columns.Add("Rozmiar Koła", 80);
                    listView_container.Columns.Add("Typ", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Kolo)
                            Szukaj(r);
                    }
                    break;

                case "Amor":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Rodzaj Amortyzacji", 130);
                    listView_container.Columns.Add("Skok [mm]", 65);
                    listView_container.Columns.Add("Rozmiar Koła", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is AmortyzatorPrzedni || r is AmortyzatorTylny)
                            Szukaj(r);
                    }
                    break;

                case "AmorP":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Rodzaj Amortyzacji", 130);
                    listView_container.Columns.Add("Skok [mm]", 65);
                    listView_container.Columns.Add("Rozmiar Koła", 80);
                    listView_container.Columns.Add("Materiał", 80);
                    listView_container.Columns.Add("Średnica [mm]", 80);
                    foreach (var r in przedmioty)
                    {
                        if (r is AmortyzatorPrzedni)
                            Szukaj(r);
                    }
                    break;

                case "AmorT":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 70);
                    listView_container.Columns.Add("Rodzaj Amortyzacji", 120);
                    listView_container.Columns.Add("Skok [mm]", 65);
                    listView_container.Columns.Add("Rozmiar Koła", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is AmortyzatorTylny)
                            Szukaj(r);
                    }
                    break;

                case "Hamulce":
                    DodajBazowe();
                    listView_container.Columns.Add("Rodzaj", 120);
                    listView_container.Columns.Add("Położenie", 60);
                    listView_container.Columns.Add("Kolor", 50);
                    listView_container.Columns.Add("Typ", 70);

                    foreach (var r in przedmioty)
                    {
                        if (r is Hamulec)
                            Szukaj(r);
                    }
                    break;

                case "Przerzutki":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 50);
                    listView_container.Columns.Add("Ilość biegów", 80);
                    listView_container.Columns.Add("Położenie", 60);

                    foreach (var r in przedmioty)
                    {
                        if (r is Przerzutka)
                            Szukaj(r);
                    }
                    break;

                //=======================AKCESORIA======================

                case "Akcesoria":
                    DodajBazowe();

                    foreach (var r in przedmioty)
                    {
                        if (r is Akcesoria)
                            Szukaj(r);
                    }
                    break;

                case "Kaski":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Rozmiar", 80);
                    listView_container.Columns.Add("Masa [kg]", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Kask)
                            Szukaj(r);
                    }
                    break;

                case "Bidony":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Pojemnosc [l]", 80);
                    listView_container.Columns.Add("Masa [kg]", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Bidon)
                            Szukaj(r);
                    }
                    break;

                case "Liczniki":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Wodoodpornosc", 80);
                    listView_container.Columns.Add("Działanie [h]", 80);
                    listView_container.Columns.Add("Funkcje", 180);

                    foreach (var r in przedmioty)
                    {
                        if (r is Licznik)
                            Szukaj(r);
                    }
                    break;

                case "Lusterka":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Rodzaj", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Lusterko)
                            Szukaj(r);
                    }
                    break;

                case "Narzedzia":
                    DodajBazowe();
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Rodzaj", 180);

                    foreach (var r in przedmioty)
                    {
                        if (r is Narzedzia)
                            Szukaj(r);
                    }
                    break;

                case "Oswietlenie":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor świecenia", 150);
                    listView_container.Columns.Add("Rodzaj świecenia", 180);

                    foreach (var r in przedmioty)
                    {
                        if (r is Oswietlenie)
                            Szukaj(r);
                    }
                    break;

                case "Pokrowce":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Rodzaj", 100);

                    foreach (var r in przedmioty)
                    {
                        if (r is Pokrowiec)
                            Szukaj(r);
                    }
                    break;

                case "Rekawiczki":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Plec", 80);
                    listView_container.Columns.Add("Rozmiar", 80);

                    foreach (var r in przedmioty)
                    {
                        if (r is Rekawiczki)
                            Szukaj(r);
                    }
                    break;

                case "Stopki":
                    DodajBazowe();
                    listView_container.Columns.Add("Kolor", 80);
                    listView_container.Columns.Add("Material", 80);
                    listView_container.Columns.Add("Rodzaj", 100);

                    foreach (var r in przedmioty)
                    {
                        if (r is Stopka)
                            Szukaj(r);
                    }
                    break;

                default:
                    break;
            }
        }

        private void treeView_kategorie_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ZaladujDane();
        }

        private void pictureBox_koszyk_Click(object sender, EventArgs e)
        {
            if (koszyk == null)
            {
                koszyk = new Koszyk(this, true);
            }
            else
            {
                koszyk.Widocznosc(true);
            }
        }

        //Pola
        private Koszyk koszyk;
        private void SprawdzKoszyk()
        {
            if (koszyk == null)
            {
                koszyk = new Koszyk(this);
            }
        }

        private void button_kup_Click(object sender, EventArgs e)
        {
            List<IItem> przedmioty = DataSourceSQL.Instance.WczytajDane();
            IItem przedmiot = null;
            SprawdzKoszyk();
            int id, ilosc = 0, iloscKupionych;

            Zamowienie z1 = new Zamowienie
            {
                Data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            };

            ListView.SelectedListViewItemCollection selectedItems = listView_container.SelectedItems;
            foreach (ListViewItem ob in selectedItems)
            {
                if (Int32.TryParse(ob.Text, out id) && Int32.TryParse(textBox_ilosc.Text, out iloscKupionych)) 
                {
                    foreach (var p in przedmioty)
                    {
                        if (p.ID == id)
                        {
                            ilosc = p.Ilosc;
                            przedmiot = p;
                            break;
                        }

                    }
                    if (ilosc - iloscKupionych >= 0)
                    {
                        DataSourceSQL.Instance.UstawIlosc(przedmiot, ilosc - iloscKupionych);
                        z1.towary.Add(przedmiot);
                        z1.ilosc.Add(iloscKupionych);
                        MessageBox.Show("Przedmot: " + przedmiot.Nazwa + " został poprawnie kupiony, ilość: " + iloscKupionych + ".", "Zakupiono przdmiot!");
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas kupowania przdmiotu!" + Environment.NewLine + "Zbyt mała ilość towaru.", "Błąd!");
                    }
                }
            }

            if (z1.ilosc.ToArray().Length > 0)
            {
                DataSourceSQL.Instance.DodajZamowienie(z1);
                ZaladujDane();
            }
        }

        private void button_doKoszyka_Click(object sender, EventArgs e)
        {
            List<IItem> przedmioty = DataSourceSQL.Instance.WczytajDane();
            IItem przedmiot = null;
            SprawdzKoszyk();
            int id, ilosc = 0;
            ListView.SelectedListViewItemCollection selectedItems = listView_container.SelectedItems;
            foreach (ListViewItem ob in selectedItems)
            {
                if (Int32.TryParse(ob.Text, out id))
                {
                    foreach (var p in przedmioty)
                    {
                        if (p.ID == id)
                        {
                            ilosc = p.Ilosc;
                            przedmiot = p;
                            break;
                        }
                    }
                    if (ilosc - 1 >= 0)
                    {
                        try
                        {
                            koszyk.Dodaj(przedmiot);
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                        MessageBox.Show("Przedmot: " + przedmiot.Nazwa + " został dodany do koszyka.", "Dodano do koszyka!");
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas dodawania do koszyka!" + Environment.NewLine + "Zbyt mała ilość towaru.", "Błąd!");
                    }
                }
            }
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            Szukana = textBox_szukaj.Text;
            ZaladujDane();
        }


        private void button_orders_Click(object sender, EventArgs e)
        {
            if (textBox_orders.Visible)
            {
                textBox_orders.Visible = false;
                button_orders.Text = "Zamówienia";
                button_doKoszyka.Visible = true;
                treeView_kategorie.Visible = true;
                label_ilosc.Visible = true;
                button_kup.Visible = true;
                button_szukaj.Visible = true;
                textBox_ilosc.Visible = true;
                textBox_szukaj.Visible = true;
                pictureBox_koszyk.Visible = true;
                listView_container.Visible = true;
            }
            else
            {
                List<Zamowienie> zam = DataSourceSQL.Instance.WyswietlZamowienia();
                StringBuilder str = new StringBuilder();
                foreach (var x in zam)
                {
                    str.Append(x.Wypisz());
                }
                textBox_orders.Visible = true;
                button_orders.Text = "Sklep";
                textBox_orders.Text = str.ToString();
                button_doKoszyka.Visible = false;
                treeView_kategorie.Visible = false;
                label_ilosc.Visible = false;
                button_kup.Visible = false;
                button_szukaj.Visible = false;
                textBox_ilosc.Visible = false;
                textBox_szukaj.Visible = false;
                pictureBox_koszyk.Visible = false;
                listView_container.Visible = false;
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if (!fd.Visible)
            {
                if (fd.IsDisposed)
                    fd = new FormDodawanie(); 
                fd.Show();
            }
            else
            {
                fd.Dispose();
            }
        }

        private void button_zwieksz_Click(object sender, EventArgs e)
        {
            List<IItem> przedmioty = DataSourceSQL.Instance.WczytajDane();
            IItem przedmiot = null;
            SprawdzKoszyk();
            int id, ilosc = 0, iloscDodanych;

            ListView.SelectedListViewItemCollection selectedItems = listView_container.SelectedItems;
            foreach (ListViewItem ob in selectedItems)
            {
                if (Int32.TryParse(ob.Text, out id) && Int32.TryParse(textBox_ilosc.Text, out iloscDodanych)) 
                {
                    foreach (var p in przedmioty)
                    {
                        if (p.ID == id)
                        {
                            ilosc = p.Ilosc;
                            przedmiot = p;
                            break;
                        }

                    }
                    if (iloscDodanych > 0)
                    {
                        DataSourceSQL.Instance.UstawIlosc(przedmiot, ilosc + iloscDodanych);
                        MessageBox.Show("Ilość przedmotu: " + przedmiot.Nazwa + " została zwiększona o: " + iloscDodanych + ".", "Zwiększono ilość!");
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas przyjmowania przdmiotu!" + Environment.NewLine + "Niepoprawna wartość!", "Błąd!");
                    }
                }
            }
            ZaladujDane();
        }
    }
}
