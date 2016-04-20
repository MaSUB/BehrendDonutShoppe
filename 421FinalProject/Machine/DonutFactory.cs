using System;
using _421FinalProject.Orders;

namespace _421FinalProject.Machine {
    class DonutFactory : DonutIF {

        DonutAC donut;

        public string description() {
            return donut.description();
        }

        public double getPrice() {
            return donut.getPrice();
        }
    }
}
