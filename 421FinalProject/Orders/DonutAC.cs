using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Orders {
    abstract class DonutAC : DonutIF {

        internal double price;

        /// <summary>
        ///     gets all the needed attributes of the donuts
        /// </summary>
        public abstract double getPrice();
        public abstract string description();
        public abstract int getPrepTime();
        
    }
}


