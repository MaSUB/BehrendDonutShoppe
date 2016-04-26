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
                donut = new RegularDonut();
                return donut;
                case "Behrend":
                donut = new BehrendDonut();
                return donut;
                case "Chocolate":
                donut = new ChocolateDonut();
                return donut;
                case "Maple":
                donut = new MDonut();
                return donut;
            }

            return donut;
        }

        public int getPrepTime() {
            return donut.getPrepTime();
        }
    }
}
