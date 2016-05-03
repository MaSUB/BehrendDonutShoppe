using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee {
    abstract class CoffeeAC : CoffeeIF {
        internal double cost;
        internal string name;
        public double getMenuPrice() {
            return cost;
        }
        public string getName() {
            return name;
        }
        public double getCondimentPrice() {
            return 0;
        }
    }

    class Regular : CoffeeAC {
        public Regular() {
            cost = 2;
            name = "Regular";
        }
    }

    class Mocha : CoffeeAC {
        public Mocha() {
            cost = 4;
            name = "Mocha";
        }
    }

    class Cappuccino : CoffeeAC {
        public Cappuccino() {
            cost = 3;
            name = "Cappuccino";
        }
    }

    class Latte : CoffeeAC {
        public Latte() {
            cost = 6;
            name = "Latte";
        }
    }
}
