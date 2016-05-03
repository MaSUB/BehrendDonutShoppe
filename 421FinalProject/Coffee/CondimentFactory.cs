using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee {
    class CondimentFactory : CoffeeCondimentAC {

        CoffeeCondimentAC cac;

        public CoffeeCondimentAC getCondiment(string s) {

            cac = (CoffeeCondimentAC) Activator.CreateInstance(Type.GetType("421FinalProject.Coffee" + "." + s));
            return cac;

        }
    }
}
