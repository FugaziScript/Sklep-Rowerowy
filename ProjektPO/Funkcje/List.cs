using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public static class ListMgm {
        public static void CopyList(List<IItem> src, ref List<IItem> dest) {
            dest.Clear();
            for(int i=0; i<src.Count(); i++) {
                dest.Add(src[i]);
            }
        }
        public static void RemovePositions(ref List<IItem> res, List<int>positions) {
            foreach(int position in positions) {
                res.RemoveAt(position);
            }
        }
    }
}
