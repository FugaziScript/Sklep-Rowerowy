using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO.Test {
    public abstract partial class Object {
        private static BMX CreateBMX(bool błąd=false) {
            List<IItem> czesci = new List<IItem>(0);
            if (błąd == false) {
                czesci.Add(new Rama());
            }
            czesci.Add(new Kola());
            czesci.Add(new Siodełko());
            czesci.Add(new HamulecPrzedni());
            czesci.Add(new HamulecTylny());
            BMX bmx = null;
            try {
                bmx = new BMX(czesci);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            
            return bmx;
        }
    }
}
