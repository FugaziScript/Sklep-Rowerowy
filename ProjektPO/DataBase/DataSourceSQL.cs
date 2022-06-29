using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace Projekt_PO

{
    public class DataSourceSQL : IDataSource //Klasa do komunikacji z bazą danych.
    {
        private static DataSourceSQL instance;
        //Metoda do załadowywania Connection Stringa.
        private DataSourceSQL()
        {

        }

        public static DataSourceSQL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataSourceSQL();
                }
                return instance;
            }
        }

        private string LoadConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<IItem> WczytajDane()
        {
            int i;
            List<IItem> items = new List<IItem>();
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                //cnn.Execute("delete from Zamowienia"); //Czyszczeni zamówień do testów

                //==========================CZESCI=========================

                var output1 = cnn.Query<Kierownica>("select * from Przedmioty left join Kierownice on Przedmioty.IDparam=Kierownice.IDparam where TypPrzedmiotu='Kierownica'");
                foreach (var e in output1)
                    items.Add(e);

                var output2 = cnn.Query<Rama>("select * from Przedmioty left join Ramy on Przedmioty.IDparam=Ramy.IDparam where TypPrzedmiotu='Rama'");
                foreach (var e in output2)
                    items.Add(e);

                var output5 = cnn.Query<Hamulec>("select * from Przedmioty left join Hamulce on Przedmioty.IDparam=Hamulce.IDparam where TypPrzedmiotu='Hamulec'");
                foreach (var e in output5)
                    items.Add(e);

                var output7 = cnn.Query<AmortyzatorPrzedni>("select * from Przedmioty left join AmorP on Przedmioty.IDparam=AmorP.IDparam where TypPrzedmiotu='AmorP'");
                foreach (var e in output7)
                    items.Add(e);

                var output8 = cnn.Query<AmortyzatorTylny>("select * from Przedmioty left join AmorT on Przedmioty.IDparam=AmorT.IDparam where TypPrzedmiotu='AmorT'");
                foreach (var e in output8)
                    items.Add(e);

                var output3 = cnn.Query<Siodelko>("select * from Przedmioty left join Siodelka on Przedmioty.IDparam=Siodelka.IDparam where TypPrzedmiotu='Siodelko'");
                foreach (var e in output3)
                    items.Add(e);

                var output15 = cnn.Query<Przerzutka>("select * from Przedmioty left join Przerzutki on Przedmioty.IDparam=Przerzutki.IDparam where TypPrzedmiotu='Przerzutka'");
                foreach (var e in output15)
                    items.Add(e);

                var output17 = cnn.Query<Kolo>("select * from Przedmioty left join Kola on Przedmioty.IDparam=Kola.IDparam where TypPrzedmiotu='Kolo'");
                foreach (var e in output17)
                    items.Add(e);

                //=======================AKCESORIA======================

                var output6 = cnn.Query<Bidon>("select * from Przedmioty left join Bidony on Przedmioty.IDparam=Bidony.IDparam where TypPrzedmiotu='Bidon'");
                foreach (var e in output6)
                    items.Add(e);

                var output9 = cnn.Query<Kask>("select * from Przedmioty left join Kaski on Przedmioty.IDparam=Kaski.IDparam where TypPrzedmiotu='Kask'");
                foreach (var e in output9)
                    items.Add(e);

                var output10 = cnn.Query<Lusterko>("select * from Przedmioty left join Lusterka on Przedmioty.IDparam=Lusterka.IDparam where TypPrzedmiotu='Lusterko'");
                foreach (var e in output10)
                    items.Add(e);

                var output11 = cnn.Query<Stopka>("select * from Przedmioty left join Stopki on Przedmioty.IDparam=Stopki.IDparam where TypPrzedmiotu='Stopka'");
                foreach (var e in output11)
                    items.Add(e);

                var output12 = cnn.Query<Rekawiczki>("select * from Przedmioty left join Rekawiczki on Przedmioty.IDparam=Rekawiczki.IDparam where TypPrzedmiotu='Rekawiczka'");
                foreach (var e in output12)
                    items.Add(e);

                var output13 = cnn.Query<Pokrowiec>("select * from Przedmioty left join Pokrowce on Przedmioty.IDparam=Pokrowce.IDparam where TypPrzedmiotu='Pokrowiec'");
                foreach (var e in output13)
                    items.Add(e);

                var output16 = cnn.Query<Narzedzia>("select * from Przedmioty left join Narzedzia on Przedmioty.IDparam=Narzedzia.IDparam where TypPrzedmiotu='Narzedzie'");
                var output16b = cnn.Query<string>("select Rodzaj from Przedmioty left join Narzedzia on Przedmioty.IDparam=Narzedzia.IDparam where TypPrzedmiotu='Narzedzie'");
                i = 0;
                foreach (var x in output16)
                {
                    string[] dsf = output16b.ToArray();
                    foreach (var xd in dsf[i].Split(','))
                    {
                        x.narzedzia.Add((RodzajNarzedzi)Enum.Parse(typeof(RodzajNarzedzi), xd, true));
                    }
                    i++;
                }
                foreach (var e in output16)
                    items.Add(e);

                var output18 = cnn.Query<Licznik>("select * from Przedmioty left join Liczniki on Przedmioty.IDparam=Liczniki.IDparam where TypPrzedmiotu='Licznik'");
                var output18b = cnn.Query<string>("select FunkcjeS from Przedmioty left join Liczniki on Przedmioty.IDparam=Liczniki.IDparam where TypPrzedmiotu='Licznik'");
                i = 0;
                foreach (var x in output18)
                {
                    string[] dsf = output18b.ToArray();
                    foreach (var xd in dsf[i].Split(','))
                    {
                        x.funkcje.Add((FunkcjeLicznika)Enum.Parse(typeof(FunkcjeLicznika), xd, true));
                    }
                    i++;
                    items.Add(x);
                }

                var output19 = cnn.Query<Oswietlenie>("select * from Przedmioty left join Oswietlenie on Przedmioty.IDparam=Oswietlenie.IDparam where TypPrzedmiotu='Oswietlenie'");
                var output19b = cnn.Query<string>("select KolorS from Przedmioty left join Oswietlenie on Przedmioty.IDparam=Oswietlenie.IDparam where TypPrzedmiotu='Oswietlenie'");
                var output19c = cnn.Query<string>("select TrybS from Przedmioty left join Oswietlenie on Przedmioty.IDparam=Oswietlenie.IDparam where TypPrzedmiotu='Oswietlenie'");
                i = 0;
                foreach (var x in output19)
                {
                    string[] dsf = output19b.ToArray();
                    string[] dsf2 = output19c.ToArray();
                    foreach (var xd in dsf[i].Split(','))
                    {
                        x.kolor_swiecenia.Add((Kolory)Enum.Parse(typeof(Kolory), xd, true));
                    }
                    foreach (var xd in dsf2[i].Split(','))
                    {
                        x.tryb_swiecenia.Add((TrybSwiecenia)Enum.Parse(typeof(TrybSwiecenia), xd, true));
                    }
                    i++;
                    items.Add(x);
                }

                return items;
            }
        }

        public void DodajElement(IItem obj)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                if (obj is Rama)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Ramy");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Rama','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Ramy values (" + index + ", @Kolor, @Typ, @Material, @Rozmiar, @Waga, @SrednicaSztycy, @RozmiarKola)", obj);
                }
                else if (obj is Kolo)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Kola");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Kolo','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Kola values (" + index + ", @Kolor, @Material, @Rozmiar, @Typ)", obj);
                }
                else if (obj is AmortyzatorPrzedni)
                {
                    var output = cnn.Query<int>("select max(IDparam) from AmorP");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'AmorP','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into AmorP values (" + index + ", @Kolor, @Material, @RodzajAmortyzacji, @Skok, @RozmiarKola, @SrednicaSztycy)", obj);
                }
                else if (obj is AmortyzatorTylny)
                {
                    var output = cnn.Query<int>("select max(IDparam) from AmorT");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'AmorT','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into AmorT values (" + index + ", @Kolor, @RodzajAmortyzacji, @Skok, @RozmiarKola)", obj);
                }
                else if (obj is Bidon)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Bidony");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Bidon','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Bidony values (" + index + ", @Pojemnosc, @Masa, @Kolor, @Material)", obj);
                }
                else if (obj is Hamulec)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Hamulce");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Hamulec','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Hamulce values (" + index + ", @TypHamulca, @Polozenie, @Typ, @Kolor)", obj);
                }
                else if (obj is Kask)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Kaski");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Kask','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Kaski values (" + index + ", @Plec, @Material, @Masa, @Kolor, @Rozmiar, @Rozmiar)", obj);
                }
                else if (obj is Kierownica)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Kierownice");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Kierownica','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Kierownice values (" + index + ", @Kolor, @Typ, @Material, @Szerokosc)", obj);
                }
                else if (obj is Licznik)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Liczniki");
                    int index = output.First() + 1;
                    StringBuilder s = new StringBuilder();
                    Licznik obj2 = (Licznik)obj;
                    foreach (var c in obj2.funkcje)
                    {
                        s.Append(c.ToString() + ",");
                    }
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Licznik','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Liczniki values (" + index + ", @IP, @Czas_pracy, @Kolor, " + s + ")", obj);
                }
                else if (obj is Lusterko)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Lusterka");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Lusterko','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Lusterka values (" + index + ", @Kolor, @Rodzaj_lusterka, @Material)", obj);
                }
                else if (obj is Narzedzia)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Narzedzia");
                    int index = output.First() + 1;
                    StringBuilder s = new StringBuilder();
                    Narzedzia obj2 = (Narzedzia)obj;
                    foreach (var c in obj2.narzedzia)
                    {
                        s.Append(c.ToString() + ",");
                    }
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Narzedzie','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Narzedzia values (" + index + ", @Material, " + s + ")", obj);
                }
                else if (obj is Oswietlenie)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Oswietlenie");
                    int index = output.First() + 1;
                    StringBuilder s = new StringBuilder();
                    StringBuilder s2 = new StringBuilder();
                    Oswietlenie obj2 = (Oswietlenie)obj;
                    foreach (var c in obj2.kolor_swiecenia)
                    {
                        s.Append(c.ToString() + ",");
                    }
                    foreach (var c in obj2.tryb_swiecenia)
                    {
                        s2.Append(c.ToString() + ",");
                    }
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Oswietlenie','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Oswietlenie values (" + index + ", @Material, " + s + ", " + s2 + ")", obj);
                }
                else if (obj is Pokrowiec)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Pokrowce");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Pokrowiec','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Pokrowce values (" + index + ", @Material, @Kolor, @Typ)", obj);
                }
                else if (obj is Przerzutka)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Przerzutki");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Przerzutka','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Przerzutki values (" + index + ", @Kolor, @IloscPrzelozen, @Polozenie)", obj);
                }
                else if (obj is Rekawiczki)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Rekawiczki");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Rekawiczka','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Rekawiczki values (" + index + ", @Material, @Plec, @Rozmiar, @Kolor)", obj);
                }
                else if (obj is Siodelko)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Siodelka");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Siodelko','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Siodelka values (" + index + ", @Kolor, @Typ, @Plec, @Material)", obj);
                }
                else if (obj is Stopka)
                {
                    var output = cnn.Query<int>("select max(IDparam) from Stopki");
                    int index = output.First() + 1;
                    cnn.Execute("insert into Przedmioty (Nazwa, Producent, Ilosc, Cena, TypPrzedmiotu, IDparam) values (@Nazwa,@Producent,@Ilosc,@Cena,'Stopka','" + index.ToString() + "')", obj);
                    cnn.Execute("insert into Stopki values (" + index + ", @Material, @Rodzaj, @Kolor)", obj);
                }
            }
        }

        public void UstawIlosc(IItem obj, int ilosc)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                string order44 = String.Format("UPDATE Przedmioty SET Ilosc='{0}' WHERE ID='{1}'", ilosc, obj.ID);
                cnn.Execute(order44);
            }
        }

        public List<Zamowienie> WyswietlZamowienia()
        {
            List<IItem> items = WczytajDane();
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<Zamowienie> zam = new List<Zamowienie>();
                var zam2 = cnn.Query<Zamowienie>("SELECT * FROM Zamowienia");
                var output2 = cnn.Query<string>("SELECT IDtowarow FROM Zamowienia");
                var output3 = cnn.Query<string>("SELECT IloscTowaru FROM Zamowienia");
                int i = 0;
                foreach (var x in zam2)
                {
                    string[] dsf = output2.ToArray();
                    string[] dsf2 = output3.ToArray();
                    foreach (var xd in dsf[i].Split(','))
                    {
                        foreach (var it in items)
                        {
                            if (it.ID.ToString() == xd)
                            {
                                x.towary.Add(it);
                                break;
                            }
                        }
                    }
                    foreach (var xd in dsf2[i].Split(','))
                    {
                        if (xd != "")
                            x.ilosc.Add(int.Parse(xd));
                    }
                    zam.Add(x);
                    i++;
                }
                return zam;
            }
        }

        public void DodajZamowienie(Zamowienie obj)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                StringBuilder tow = new StringBuilder();
                StringBuilder ilo = new StringBuilder();
                foreach (var x in obj.towary)
                    tow.Append(x.ID.ToString() + ",");

                foreach (var x in obj.ilosc)
                    ilo.Append(x.ToString() + ",");


                cnn.Execute("insert into Zamowienia (IDtowarow, IloscTowaru, Data) values ('" + tow.ToString() + "','" + ilo.ToString() + "',@Data)", obj);
            }
        }
    }
}
