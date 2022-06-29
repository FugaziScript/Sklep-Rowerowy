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
    public partial class FormDodawanie : Form
    {
        public FormDodawanie()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox_typ.SelectedItem.ToString())
            {
                case "Rama":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Kolor,Typ,Rozmiar,Waga,Średnica Stycy,Rozmiar Koła";
                    break;

                case "Hamulec":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Typ Hamulca,Położenie,Typ,Kolor";
                    break;

                case "Kierownica":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Kolor,Typ,Materiał,Szerokość";
                    break;

                case "Amortyzator Przedni":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Kolor,Materiał,Rozmiar Koła,Skok,Rodzaj Amortyzacji,Średnica Sztycy";
                    break;

                case "Amortyzator Tylni":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Kolor,Rozmiar Koła,Skok,Rodzaj Amortyzacji";
                    break;

                case "Przerzutka":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Kolor,Ilość przełożeń,Położenie";
                    break;

                case "Siodełko":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Kolor,Płeć,Typ,Materiał";
                    break;

                case "Koło":
                    label_wzor.Text = "Nazwa,Ilość,Producent,Cena,Rozmiar,Kolor,Typ,Materiał";
                    break;
            }
            textBox_dane.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Rama Kils,Trek,1233.33,Czerwony,Gorski,M,3.66,56.4,26
            List<IItem> item = new List<IItem>();
            string[] dane = textBox_dane.Text.Split(',');
            if(listBox_typ.SelectedItem != null)
            {
                switch (listBox_typ.SelectedItem.ToString())
                {
                    case "Rama":
                        if (dane.Length != 11)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new Rama
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[4], true),
                                Typ = (Typy)Enum.Parse(typeof(Typy), dane[5], true),
                                Rozmiar = (Rozmiary)Enum.Parse(typeof(Rozmiary), dane[6], true),
                                Waga = double.Parse(dane[7].Replace('.', ',')),
                                SrednicaSztycy = double.Parse(dane[8].Replace('.', ',')),
                                RozmiarKola = double.Parse(dane[9].Replace('.', ',')),
                                Material = (Materialy)Enum.Parse(typeof(Materialy), dane[10], true),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Hamulec":
                        if (dane.Length != 8)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new Hamulec
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                TypHamulca = (TypyHamulca)Enum.Parse(typeof(TypyHamulca), dane[4], true),
                                Polozenie = (Polozenia)Enum.Parse(typeof(Polozenia), dane[5], true),
                                Typ = (Typy)Enum.Parse(typeof(Typy), dane[6], true),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[7], true),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Kierownica":
                        if (dane.Length != 8)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new Kierownica
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[4], true),
                                Typ = (Typy)Enum.Parse(typeof(Typy), dane[5], true),
                                Material = (Materialy)Enum.Parse(typeof(Materialy), dane[6], true),
                                Szerokosc = double.Parse(dane[7].Replace('.', ',')),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Amortyzator Przedni":
                        if (dane.Length != 10)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new AmortyzatorPrzedni
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[4], true),
                                Material = (Materialy)Enum.Parse(typeof(Materialy), dane[5], true),
                                RozmiarKola = double.Parse(dane[6].Replace('.', ',')),
                                Skok = double.Parse(dane[7].Replace('.', ',')),
                                RodzajAmortyzacji = (RodzajeAmortyzacji)Enum.Parse(typeof(RodzajeAmortyzacji), dane[8], true),
                                SrednicaSztycy = double.Parse(dane[9].Replace('.', ',')),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Amortyzator Tylni":
                        if (dane.Length != 8)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new AmortyzatorTylny
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[4], true),
                                RozmiarKola = double.Parse(dane[5].Replace('.', ',')),
                                Skok = double.Parse(dane[6].Replace('.', ',')),
                                RodzajAmortyzacji = (RodzajeAmortyzacji)Enum.Parse(typeof(RodzajeAmortyzacji), dane[7], true),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Przerzutka":
                        if (dane.Length != 7)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new Przerzutka
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[4], true),
                                IloscPrzelozen = int.Parse(dane[5]),
                                Polozenie = (Polozenia)Enum.Parse(typeof(Polozenia), dane[6], true),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Siodełko":
                        if (dane.Length != 8)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new Siodelko
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[4], true),
                                Plec = (Plcie)Enum.Parse(typeof(Plcie), dane[5], true),
                                Typ = (Typy)Enum.Parse(typeof(Typy), dane[6], true),
                                Material = (Materialy)Enum.Parse(typeof(Materialy), dane[7], true),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "Koło":
                        if (dane.Length != 8)
                        {
                            MessageBox.Show("Nieprawidłowa ilość danych!", "Błąd!");
                            break;
                        }

                        try
                        {
                            item.Add(new Kolo
                            {
                                ID = 1234,
                                Nazwa = dane[0],
                                Ilosc = int.Parse(dane[1]),
                                Producent = (Producents)Enum.Parse(typeof(Producents), dane[2], true),
                                Cena = double.Parse(dane[3].Replace('.', ',')),
                                Rozmiar = double.Parse(dane[4].Replace('.', ',')),
                                Kolor = (Kolory)Enum.Parse(typeof(Kolory), dane[5], true),
                                Typ = (Typy)Enum.Parse(typeof(Typy), dane[6], true),
                                Material = (Materialy)Enum.Parse(typeof(Materialy), dane[7], true),
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Nieprawidłowe dane!", "Błąd!");
                            break;
                        }
                        break;

                    case "null":
                        break;
                }
            }
            if(item.Count > 0 && item.First().Ilosc < 0)
                MessageBox.Show("Nieprawidłowa ilość!", "Błąd!");
            else
            {
                if (item.Count > 0)
                {
                    DataSourceSQL.Instance.DodajElement(item.First());
                    textBox_dane.Text = "";
                    MessageBox.Show("Dodano element!", "Dodano");
                }
            }
        }
    }
}
