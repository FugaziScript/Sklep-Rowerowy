using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public static partial class tostr { //Klasa zwracająca ciąg znaków odpowiedni dla typów wyliczeniowych
        //Typ pokrowca
        /// <summary>
        /// Funkcja zwraca przyjazną użytkowsikowi wartość typu wyliczeniowego TypPokrowca.
        /// </summary>
        /// <param name="pokrowiec"></param>
        /// <returns></returns>
        public static string TypPokrowca2str(TypPokrowca pokrowiec) {
            switch (pokrowiec) {
                case TypPokrowca.na_rower:
                    return "na rower";
                case TypPokrowca.na_siodelko:
                    return "na siodełko";
                default:
                    return pokrowiec.ToString();
            }
        }
        /// <summary>
        /// Funkcja zwraca przyjazną użytkowsikowi wartość typu wyliczeniowego Materiał.
        /// </summary>
        /// <param name="materiał"></param>
        /// <returns></returns>
        public static string Materiał2str(Material material) {
            switch (material) {
                case Material.Aluminium:
                    return "aluminium";
                case Material.Bawelna:
                    return "bawełna";
                case Material.Plastik:
                    return "plastik";
                case Material.Poliester:
                    return "poliester";
                case Material.Stal:
                    return "stal";
                case Material.Wlokno_Szklane:
                    return "włókno szklane";
                default:
                    return material.ToString(); //W sumie jednowyrazowych dodawać nie trzeba
            }
        }
        /// <summary>
        /// Funkcja zwraca przyjazną użytkowsikowi wartość typu wyliczeniowego IP.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static string IP2str(IP ip) {
            string ip_str = ip.ToString();
            ip_str = ip_str.Remove(0, 2); //Usuwamy pierwsze litery
            return ip_str;
        }
        /// <summary>
        /// Funkcja zwraca przyjazną użytkowsikowi wartość typu wyliczeniowego IP.
        /// </summary>
        /// <param name="tryb_świecenia"></param>
        /// <returns></returns>
        public static string TrybŚwiecenia2str(TrybSwiecenia tryb_świecenia) {
            switch (tryb_świecenia) {
                case TrybSwiecenia.migajacy_dwukolorowy:
                    return "migający dwukolorowy";
                default:
                    return tryb_świecenia.ToString();
            }
        }
    }
}
