using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class ZawartoscLst {
        public ZawartoscLst() {
            ilosc = 0;
            element = null;
        }
        public int ilosc { get; set; }
        public IItem element { get; set; }
        public override string ToString() {
            string str = "Element: " + element.Nazwa;
            str += "\tIlosc: ";
            str += ilosc.ToString();
            str += "\n";
            return str;
        }
        public List<IItem> ToIItem() {
            List<IItem> temp = new List<IItem>(0);
            for(int i=0; i<ilosc; i++) {
                temp.Add(element);
            }
            return temp;
        }
    }
}
