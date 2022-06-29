using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Singleton {
        private Singleton() { }
        private static Singleton instancja;
        private static readonly object utworzono = new object();
        public static Singleton Zablokuj() {
            if (instancja == null) {
                lock (utworzono) {
                    instancja = new Singleton();
                }
            }
            return instancja;
        }
    }
}
