﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _421FinalProject.Machine;
using _421FinalProject.Orders;

namespace _421FinalProject.Employee {
    abstract class EmployeeAC : EmployeeIF {


        internal string name { get; set; }
        internal int age { get; set; }
        internal Order currentOrder;


        public void getNewOrder(Order o) {
            currentOrder = o;
        }

        abstract public Order handleOrder();

        abstract public CoffeeIF prepareCoffee(CoffeeMachine cm);

        abstract public DonutIF prepareDonut(DonutMachine dm);
    }
}