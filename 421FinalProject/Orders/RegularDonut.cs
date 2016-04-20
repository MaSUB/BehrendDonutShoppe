using System;

namespace _421FinalProject.Orders {
    class RegularDonut : DonutAC {

        /// <summary>
        ///     This used to set the actual price of the different donuts that are available.
        /// </summary>
        RegularDonut() {
            price = 0;  //  need to adjust the price.
        }

        public override string description() {
            return "Regular Donut:\nThis donut has a sugar glaze all over the donut.";
        }


        public override double getPrice() {
            return price;
        }

    }
}
