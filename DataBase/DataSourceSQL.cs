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
        //Metoda do załadowywania Connection Stringa.
        private static string LoadConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static List<IItem> WczytajDane()
        {
            List<IItem> items = new List<IItem>();
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output1 = cnn.Query<Kierownica>("select * from Przedmioty left join Kierownice on Przedmioty.IDparam=Kierownice.IDparam where TypPrzedmiotu='Kierownica'");
                foreach (var e in output1)
                    items.Add(e);
                
                var output2 = cnn.Query<Rama>("select * from Przedmioty left join Ramy on Przedmioty.IDparam=Ramy.IDparam where TypPrzedmiotu='Rama'");
                foreach (var e in output2)
                    items.Add(e);

                var output3 = cnn.Query<Siodelko>("select * from Przedmioty left join Siodełka on Przedmioty.IDparam=Siodełka.IDparam where TypPrzedmiotu='Siodełko'");
                foreach (var e in output3)
                    items.Add(e);

                var output4 = cnn.Query<HamulecPrzedni>("select * from Przedmioty left join HamulcePrzednie on Przedmioty.IDparam=HamulcePrzednie.IDparam where TypPrzedmiotu='HamulecP'");
                foreach (var e in output4)
                    items.Add(e);

                var output5 = cnn.Query<HamulecTylny>("select * from Przedmioty left join HamulceTylnie on Przedmioty.IDparam=HamulceTylnie.IDparam where TypPrzedmiotu='HamulecT'");
                foreach (var e in output5)
                    items.Add(e);

                var output6 = cnn.Query<Bidon>("select * from Przedmioty left join Bidony on Przedmioty.IDparam=Bidony.IDparam where TypPrzedmiotu='Bidon'");
                foreach (var e in output6)
                    items.Add(e);

                var output7 = cnn.Query<AmortyzatorPrzedni>("select * from Przedmioty left join AmortyzatoryPrzednie on Przedmioty.IDparam=AmortyzatoryPrzednie.IDparam where TypPrzedmiotu='AmortyzatoryP'");
                foreach (var e in output7)
                    items.Add(e);

                var output8 = cnn.Query<AmortyzatorTylny>("select * from Przedmioty left join AmortyzatoryTylnie on Przedmioty.IDparam=AmortyzatoryTylnie.IDparam where TypPrzedmiotu='AmortyzatoryT'");
                foreach (var e in output8)
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

                var output12 = cnn.Query<Rękawiczki>("select * from Przedmioty left join Rękawiczki on Przedmioty.IDparam=Rękawiczki.IDparam where TypPrzedmiotu='Rękawiczka'");
                foreach (var e in output12)
                    items.Add(e);

                var output13 = cnn.Query<Pokrowiec>("select * from Przedmioty left join Pokrowce on Przedmioty.IDparam=Pokrowce.IDparam where TypPrzedmiotu='Pokrowiec'");
                foreach (var e in output13)
                    items.Add(e);

                var output14 = cnn.Query<PrzerzutkiPrzednie>("select * from Przedmioty left join PrzerzutkiPrzednie on Przedmioty.IDparam=PrzerzutkiPrzednie.IDparam where TypPrzedmiotu='PrzerzutkaP'");
                foreach (var e in output14)
                    items.Add(e);

                var output15 = cnn.Query<PrzerzutkiTylne>("select * from Przedmioty left join PrzerzutkiTylnie on Przedmioty.IDparam=PrzerzutkiTylnie.IDparam where TypPrzedmiotu='PrzerzutkaT'");
                foreach (var e in output15)
                    items.Add(e);

                var output16 = cnn.Query<Narzedzia>("select * from Przedmioty left join Narzędzia on Przedmioty.IDparam=Narzędzia.IDparam where TypPrzedmiotu='Narzędzie'");
                foreach (var e in output16)
                    items.Add(e);

                var output17 = cnn.Query<Kola>("select * from Przedmioty left join Koła on Przedmioty.IDparam=Koła.IDparam where TypPrzedmiotu='Koło'");
                foreach (var e in output17)
                    items.Add(e);
                return items;
            }
        }
        public static void DodajElement(IItem obj)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Przedmioty (Nazwa, producent, Ilość, Cena) values (@Ilość, @Cena, @producent, @Nazwa)", obj);
            }
            //Trzeba dorobić do tabeli z parametrami osobne case dla każdej części.
        }
        public static void UsunElement(IItem obj)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE * FROM Przedmioty WHERE @ID", obj);
            }
            //Trzeba dorobić do tabeli z parametrami osobne case dla każdej części.
        }

        public static void UstawIlosc(IItem obj, int ilosc) //int id zamiast obj.ID
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                string order44 = String.Format("UPDATE Przedmioty SET Ilosc='{0}' WHERE ID='{1}'", ilosc, obj.ID);
                cnn.Execute(order44);
            }
        }
    }
}
