using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PO {
    public partial class koszyk_GUI : Form {
        private static List<ZawartoscLst> Convert2Struct(List<IItem> data) {
            List<IItem> res = new List<IItem>(0);
            ListMgm.CopyList(data, ref res);
            List<ZawartoscLst> temp = new List<ZawartoscLst>(0);
            int licznik;
            //Sortowanie tablicy po iD
            res.Sort((p, q) => p.ID.CompareTo(q.ID));
            ZawartoscLst tmp_el;
            int prev_ID = -1;
            for (int i=0; i<res.Count(); i++){
                tmp_el = new ZawartoscLst();
                licznik = 1;
                if (res[i].ID == prev_ID) {
                    continue;
                } else {
                    prev_ID = res[i].ID;
                }
                for(int j=i+1; j<res.Count(); j++) {
                    if (res[i].ID == res[j].ID) {
                        licznik++;
                    }
                }
                tmp_el.element = res[i];
                tmp_el.ilosc = licznik;
                temp.Add(tmp_el);
            }
            return temp;
        }
        public static void ConversionTest(List<IItem> data) {
            List<ZawartoscLst> result = new List<ZawartoscLst>(0);
            result = Convert2Struct(data);
            foreach(ZawartoscLst res in result) {
                Console.Write(res.ToString());
            }
        }
        private bool IntParse(string source, ref int result, int max_val) {
            int res = result;
            source = source.Trim();
            if (Int32.TryParse(source, out res) == true) {
                if (res > 0) {
                    if (res <= max_val) {
                        result = res;
                        return true;
                    } else {
                        MessageBox.Show("Podana wartość musi być mniejsza niż " + max_val.ToString() + "!");
                    }
                } else {
                    MessageBox.Show("Podana wartość musi być większa niż 0!");
                }
            } else {
                MessageBox.Show("Podana wartość musi być liczbą całkowitą!");
            }
            return false;
        }
        private bool IntParse(string source, ref int result) {
            int res = result;
            source = source.Trim();
            if (Int32.TryParse(source, out res) == true) {
                if (res > 0) {
                    return true;
                } else {
                    MessageBox.Show("Podana wartość musi być większa niż 0!");
                }
            } else {
                MessageBox.Show("Podana wartość musi być liczbą całkowitą!");
            }
            return false;
        }
        private int GetQuantity(int ID) {
            List<IItem> Temp = koszyk.PobierzZawartoscIItem();
            foreach (IItem element in Temp) {
                if (element.ID == ID) {
                    return element.Ilosc; //Zwracamy ilość
                }
            }
            return 0; //Zwracamy 0, jeśli nie ma takiego elementu
        }
        private int GetCount(int ID) {
            List<ZawartoscLst> Temp = koszyk.PobierzZawartoscLst();
            foreach (ZawartoscLst element in Temp) {
                if (element.element.ID == ID) {
                    return element.ilosc; //Zwracamy ilość
                }
            }
            return 0; //Zwracamy 0, jeśli nie ma takiego elementu
        }
        private bool DGV_not_restricted(int column, int row) {
            if (column != 2) {
                return false;
            }
            if (row > (this.koszyk_zawartosc_lista.Rows.Count - 1)) {
                return false;
            }
            return true;
        }
    }
}
