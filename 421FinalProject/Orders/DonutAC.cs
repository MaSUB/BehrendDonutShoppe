using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Orders {
    abstract class DonutAC : DonutIF {

        internal double price;
        internal int calories;
        internal int preptime;
        internal bool itemFinished;

        /// <summary>
        ///     These are used by the filters to decide what is to be included in the list to
        ///     be filtered. If True then it is to be included, else they are not returned.
        /// </summary>
        internal bool priceFilter { get; set; }
        internal bool glazeFilter { get; set; }
        internal bool IcingFilter { get; set; }
        internal bool caloriesFilter { get; set; }



        internal DonutAC() {
            priceFilter = true;
            caloriesFilter = true;
        }

        /// <summary>
        ///     gets all the needed attributes of the donuts
        /// </summary>
        public double getPrice() {
            return price;
        }
        public int getCalories() {
            return calories;
        }
        public abstract string description();
        public int getPrepTime() {
            return preptime;
        }

        public void setFinished(bool t) {
            itemFinished = t;
        }

        public bool isFinished() {
            return itemFinished;
        }

        public bool isGlazed() {
            return glazeFilter;
        }

        public bool isIced() {
            return IcingFilter;
        }
    }
}


