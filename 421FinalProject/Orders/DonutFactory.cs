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

            switch (s) {
                case "Regular":
                return new RegularDonut();
                case "Behrend":
                return new BehrendDonut();
                case "Chocolate":
                return new ChocolateDonut();
                case "Maple":
                return new MDonut();
            }

            return donut;
        }

        public int getPrepTime() {
            return donut.getPrepTime();
        }
    }
}
