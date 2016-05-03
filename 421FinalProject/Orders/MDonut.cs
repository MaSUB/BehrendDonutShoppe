

using System;

namespace _421FinalProject.Orders {

    class MDonut : DonutAC {

        /// <summary>
        ///     This used to set the actual price of the different donuts that are available.
        /// </summary>
        public MDonut() {
            price = 1.25;
            glazeFilter = false;
            IcingFilter = true;
            itemFinished = false;
            preptime = 15;
        }

        public override string description() {
            return "Maple Donut:\nThis donut has a maple syrup style topping";
        }

    }

}
