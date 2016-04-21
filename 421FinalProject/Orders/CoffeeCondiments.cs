using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Orders {
    abstract class CoffeeCondiments : Item {

        private int prepTime;
        private double price;

        public int getPrepTime() {
            return prepTime;
        }

        public double getPrice() {
            return price;
        }
    }
}
