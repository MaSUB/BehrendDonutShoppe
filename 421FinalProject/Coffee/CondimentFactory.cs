using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee {
    class CondimentFactory : CoffeeCondimentAC {

        CoffeeCondimentAC cac;

        public CoffeeCondimentAC getCondiment(string s) {

            switch (s) {
                case "vanilla": {
                    cac = new Vanilla();
                    return cac;
                }

                case "chocolate": {
                    cac = new Chocolate();
                    return cac;
                }

                case "cream": {
                    cac = new Cream();
                    return cac;
                }
                default: {
                    return null;
                }
            }
        }
    }
}
