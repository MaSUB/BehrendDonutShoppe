using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _421FinalProject.Orders;

namespace _421FinalProject.Filter {
    class GlazedFilter : FilterAC {
        public override List<DonutIF> filterList(List<DonutIF> d) {
            List<DonutIF> temp = new List<DonutIF>();
            for (int i = 0; i < d.Count; i++) {
                if (d[i].isGlazed()) {
                    temp.Add(d[i]);
                }
            }

            return temp;
            
        }
    }
}
