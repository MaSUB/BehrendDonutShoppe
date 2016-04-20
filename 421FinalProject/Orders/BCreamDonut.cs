using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Orders {
    class BCreamDonut : DonutAC {

        /// <summary>
        ///     This used to set the actual price of the different donuts that are available.
        /// </summary>
        public BCreamDonut() {

            price = 0;  //  need to adjust the price

        }

        public override string description() {
            return "Behrend Cream Donut:\n"+
                "This donut has a chocolate dopping and is filled with a vanilla cream inside";
        }

        public override double getPrice() {
            return price;
        }
    }
}
