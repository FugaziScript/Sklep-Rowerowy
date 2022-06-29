using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_PO{
    public interface IItem {
        int Ilosc { get; set; } //Ilość przedmiotu
        int ID { get; set; }  //Unikalny numer ID każdego przedmiotu  
        string Nazwa { get; set; }  //Nazwa przedmiotu
        double Cena { get; set; }   //Cena Przedmiotu
        Producents Producent { get; set; }  //Producent Przedmiotu
        List<string> Wypisz();   //Funkcja pozwalająca wypisać dane przedmiotu
    }
}
