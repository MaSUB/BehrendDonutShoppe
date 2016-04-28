using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee
{
    class Coffee : CoffeeIF
    {
        internal double cost;
        internal string name;
        public double getMenuPrice()
        {
            return cost;
        }
        public string getName()
        {
            return name;
        }
        public double getCondimentPrice()
        {
            return 0;
        }
    }

    class Regular : Coffee
    {
        public Regular()
        {
            cost = 2;
            name = "Regular";
        }
    }

    class Mocha : Coffee
    {
        public Mocha()
        {
            cost = 4;
            name = "Mocha";
        }
    }

    class Other : Coffee
    {
        public Other()
        {
            cost = 5;
            name = "Other";
        }
    }

    class Cappuccino : Coffee
    {
        public Cappuccino()
        {
            cost = 3;
            name = "Cappuccino";
        }
    }

    class Latte : Coffee {
        public Latte() {
            cost = 6;
            name = "Latte";
        }
    }
}
