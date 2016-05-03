using System;

namespace _421FinalProject.Orders {
    class ChocolateDonut : DonutAC {

        public ChocolateDonut() {
            price = 1.25;
            glazeFilter = false;
            IcingFilter = true;
            itemFinished = false;
            preptime = 15;
        }

        public override string description() {
            return "This donut is the regular donut with a chocolate topping.";
        }
    }
}
