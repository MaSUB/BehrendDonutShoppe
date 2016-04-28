using System;

namespace _421FinalProject.Orders {
    class DonutFactory : DonutIF {

        DonutAC donut;

        public string description() {
            return donut.description();
        }

        public double getPrice() {
            return donut.getPrice();
        }

        public DonutIF getDonut(string s) {

                donut = (DonutAC) Activator.CreateInstance(Type.GetType("421FinalProject" + "." + s));
                return donut;
               
        }

        public int getPrepTime() {
            return donut.getPrepTime();
        }
    }
}
