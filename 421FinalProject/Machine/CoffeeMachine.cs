using _421FinalProject.Coffee;
using System;
using System.Collections.Generic;

namespace _421FinalProject.Machine {
    class CoffeeMachine : MachineIF {
        CoffeeIF cif = new CoffeeWrapper(null, null);  //Regular coffee by default
        List<CoffeeIF> lcif = new List<CoffeeIF>();             //All the coffee

        public void done() {
            lcif.Add(cif);
            // GUI should the display 

        }

        public double computePrice(CoffeeIF cif) {
            return cif.getCondimentPrice() + cif.getMenuPrice();
        }

        public CoffeeIF makeCoffee(string coffee, List<string> condimentList) {
            if (condimentList.Count == 0) {
                return cif;
            }
            else {

                cif = (CoffeeIF)Activator.CreateInstance(Type.GetType("421FinalProject.Coffee" + "." + coffee));

                for (int i = 0; i < condimentList.Count; i++) {
                    CondimentFactory cf = new CondimentFactory();

                    cf.getCondiment(condimentList[i]);
                    cif = new CoffeeWrapper(cif, cf.getCondiment(condimentList[i]));
                }
                return cif;
            }
        }
    }
}
