using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee
{
    abstract class CoffeeCondimentAC
    {
        protected double cost;
        protected string name;
        public double getCost()
        {
            return cost;
        }

        public string getName()
        {
            return name;
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
