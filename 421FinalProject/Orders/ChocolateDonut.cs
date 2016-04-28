using System;

namespace _421FinalProject.Orders {
    class ChocolateDonut : DonutAC {

        public ChocolateDonut(double p) {
            price = p;
        }

        public override string description() {
            return "This donut is the regular donut with a chocolate topping.";
        }

        public override int getPrepTime() {
            return 10;
        }

        public override double getPrice() {
            return price;
        }
    }
}
