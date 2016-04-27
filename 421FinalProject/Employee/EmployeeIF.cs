using _421FinalProject.Machine;
using _421FinalProject.Orders;
using System.Collections.Generic;

namespace _421FinalProject.Employee {
    interface EmployeeIF
    {
        DonutIF prepareDonut(DonutMachine dm, string type);
        CoffeeIF prepareCoffee(CoffeeMachine cm, string coffeeName, List<string> condimentNameList);
        void getNewOrder(Order o);
        Order handleOrder();
    }
}
