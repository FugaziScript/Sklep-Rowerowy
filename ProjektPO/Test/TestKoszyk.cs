using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO.Test {
    public abstract partial class Object {
        private static void TestKoszyk() {
            List<IItem> lista = new List<IItem>(0);
            Rama ob1 = new Rama();
            ob1.ID = 10;
            ob1.Nazwa = "Rama 1";
            Rama ob2 = new Rama();
            ob2.ID = 11;
            ob2.Nazwa = "Rama 2";
            Rama ob3 = new Rama();
            ob3.ID = 12;
            ob3.Nazwa = "Rama 3";
            lista.Add(ob1);
            lista.Add(ob2);
            lista.Add(ob3);
            lista.Add(ob1);
            lista.Add(ob2);
            lista.Add(ob1);
            lista.Add(ob2);
            lista.Add(ob3);
            lista.Add(ob1);
            lista.Add(ob2);
            //Poprawny wynik:
            //Rama 1: 4
            //Rama 2: 4
            //Rama 3: 2
            koszyk_GUI.ConversionTest(lista);
        }
    }
}
