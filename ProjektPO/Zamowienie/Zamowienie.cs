using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Zamowienie
    {
        public int ID { get; set; }
        public List<IItem> towary;
        public List<int> ilosc;
        public string Data { get; set; }

        public Zamowienie()
        {
            towary = new List<IItem>();
            ilosc = new List<int>();
        }

        public string Wypisz()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Environment.NewLine + ID + ") " + Data + Environment.NewLine);
            int i = 0;
            foreach(var x in towary)
            {
                str.Append("    -" + x.ID.ToString() + ", " + x.Nazwa.ToString() + ", " + "Cena: " + x.Cena.ToString() + "zł, " + "Ilość: " + ilosc.ToArray()[i].ToString() + Environment.NewLine);
                i++;
            }
            return str.ToString();
        }
    }
}
