using _421FinalProject.Coffee;
using System.Collections.Generic;

namespace _421FinalProject.Machine {
    class CoffeeMachine : MachineIF
    {
        CoffeeIF cif = new CoffeeWrapper(new Regular(), null);  //Regular coffee by default
        List<CoffeeIF> lcif = new List<CoffeeIF>();             //All the coffee
        public void addCondiment(CoffeeCondimentAC type)
        {   
            //pass to the GUI
            //Console.WriteLine("Adding " + type.getName());
            cif = new CoffeeWrapper(cif, type);

        }

        public void done()
        {
            lcif.Add(cif);
            // GUI should the display 
            
        }

        public double computePrice(CoffeeIF cif)
        {
            return cif.getCondimentPrice() + cif.getMenuPrice();
        }

        public CoffeeIF makeCoffee(string coffee, List<string> condimentList)
        {
            if (condimentList.Count == 0)
            {
                return cif;
            }
            else
            {
                for (int i = 0; i < condimentList.Count; i++)
                {
                    cif =  new CoffeeWrapper()
                }
            }
        }
    }
}
