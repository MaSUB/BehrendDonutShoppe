using System;

namespace _421FinalProject.Orders {
    abstract class DonutAC : DonutIF {

        internal double price;

        /// <summary>
        ///     returns the price of the donut
        /// </summary>
        public abstract double getPrice();

        public abstract string description();
    }
}
