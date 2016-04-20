using _421FinalProject.Machine;
using _421FinalProject.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Employee
{
    class Employee : EmployeeIF
    {
        private string name{get; set;}
        private int age;

        public Employee(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public override DonutIF prepareDonut(DonutMachine dm)
        {
            return null;//Fix later
        }

        public override CoffeeIF prepareCoffee(CoffeeMachine cm)
        {
            return null;//Fix later
        }
    
        void override handleOrder(Order o)
        {

        }
    }
}
