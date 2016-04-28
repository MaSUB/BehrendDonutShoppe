using _421FinalProject.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee
{
    abstract class CoffeeCondimentAC : Item
    {
        internal double cost;
        internal string name;

        public string getName()
        {
            return name;
        }

        public int getPrepTime() {
            return 0;
        }

        public double getPrice() {
            return cost;
        }
    }

    class Cream : CoffeeCondimentAC
    {
        public Cream()
        {
            cost = 0.25;
            name = "cream";
        }
    }

    class Vanilla : CoffeeCondimentAC
    {
        public Vanilla()
        {
            cost = 0.50;
            name = "vanilla";
        }
    }

    class Chocolate : CoffeeCondimentAC
    {
        public Chocolate()
        {
            cost = 1.00;
            name = "chocolate";
        }
    }
}
