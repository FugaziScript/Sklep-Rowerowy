using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public static class separator {
        /// <summary>
        /// Funkcja dodaje "\n" (nowa liania) do każdego stringa na Liście, 
        /// jeśli ten nie kończy się na "\n"
        /// </summary>
        /// <param name="lista"></param>
        public static void endl(List<string> lista) {
           for(int i = 0; i<lista.Count; i++) { //Nie można użyc Foreach, ponieważ nie można w nim modyfikowac zmiennych
                if (lista[i].EndsWith("\n") == false) {
                    lista[i] += "\n";
                }
            }
        }
        /// <summary>
        /// Funcka dodaje "\n" (nowa linia) do przekazanego stringa,
        /// jeśli ten nie kończy się na "\n"
        /// </summary>
        /// <param name="element"></param>
        public static void endl(string element) {
            if (element.EndsWith("\n") == false) {
                element += "\n";
            }
        }
    }
}
