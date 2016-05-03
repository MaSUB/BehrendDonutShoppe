using _421FinalProject.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee {
    abstract class CoffeeCondimentAC : Item {


        internal double cost;
        internal string name;
        internal bool itemFinished;

        public string getName() {
            return name;
        }

        public int getPrepTime() {
            return 0;
        }

        public double getPrice() {
            return cost;
        }

        public bool isFinished() {
            return itemFinished;
        }
    }

    class Cream : CoffeeCondimentAC {
        public Cream() {
            cost = 0;
            itemFinished = false;
            name = "Cream";
        }
    }

    class Vanilla : CoffeeCondimentAC {
        public Vanilla() {
            cost = 0.50;
            itemFinished = false;
            name = "Vanilla";
        }
    }

    class Chocolate : CoffeeCondimentAC {
        public Chocolate() {
            cost = 1.00;
            itemFinished = false;
            name = "Chocolate";
        }
    }

    class Sugar : CoffeeCondimentAC {
        public Sugar() {
            cost = 0;
            itemFinished = false;
            name = "Sugar";
        }
    }
}
