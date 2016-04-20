using _421FinalProject.Machine;
using _421FinalProject.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Employee
{
    interface EmployeeIF
    {
        DonutIF prepareDonut(DonutMachine dm);
        CoffeeIF prepareCoffee(CoffeeMachine cm);
        void handleOrder(Order o);
    }
}
