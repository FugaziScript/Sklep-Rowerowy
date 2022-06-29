using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public static partial class tostr {
        //Lista List<string> wyświetlana w odpowiedniej formie
        /// <summary>
        /// Funkcja tworzy ciąg znaków z przekazanej listy typu FunkcjeLicznika.
        /// Każdy element listy zostaje poprzedzony tabulatorem ("\t") i kończy się nową linią ("\n").
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static string List2str(List<FunkcjeLicznika> lista) {
            string tekst=null;
            foreach(FunkcjeLicznika element in lista) {
                tekst += "\t" + element.ToString() + "\n";
            }
            return tekst;
        }
        //Lista List<string> wyświetlana w odpowiedniej formie
        /// <summary>
        /// Funkcja tworzy ciąg znaków z przekazanej listy typu RodzajNarzędzi.
        /// Każdy element listy zostaje poprzedzony tabulatorem ("\t") i kończy się nową linią ("\n").
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static string List2str(List<RodzajNarzedzi> lista) {
            string tekst = null;
            foreach (RodzajNarzedzi element in lista) {
                tekst += "\t" + element.ToString() + "\n";
            }
            return tekst;
        }
        /// <summary>
        /// Funkcja tworzy ciąg znaków z przekazanej listy typu TrybŚwiecenia.
        /// Każdy element listy zostaje poprzedzony tabulatorem ("\t") i kończy się nową linią ("\n").
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static string List2str(List<TrybSwiecenia> lista) {
            string tekst = null;
            foreach (TrybSwiecenia element in lista) {
                tekst += "\t" + TrybŚwiecenia2str(element) + "\n";
            }
            return tekst;
        }
        /// <summary>
        /// Funkcja tworzy ciąg znaków z przekazanej listy typu Kolor.
        /// Każdy element listy zostaje poprzedzony tabulatorem ("\t") i kończy się nową linią ("\n").
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static string List2str(List<Kolory> lista) {
            string tekst = null;
            foreach (Kolory element in lista) {
                tekst += "\t" + element.ToString() + "\n";
            }
            return tekst;
        }

        public static string List2str(List<IItem> lista) {
            string tekst = null;
            foreach (IItem item in lista) {
                tekst += "\t"+"ID: "+item.ID.ToString()+"   Nazwa: "+item.Nazwa+"\n";
            }
            return tekst;
        }
    }
}
