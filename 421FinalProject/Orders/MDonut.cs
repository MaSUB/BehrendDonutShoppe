

using System;

namespace _421FinalProject.Orders {

    class MDonut : DonutAC {

        /// <summary>
        ///     This used to set the actual price of the different donuts that are available.
        /// </summary>
        public MDonut() {
            price = 0;
        }

        public override string description() {
            return "Maple Donut:\nThis donut has a maple syrup style topping";
        }

        public override double getPrice() {
            throw new NotImplementedException();
        }
    }

}
