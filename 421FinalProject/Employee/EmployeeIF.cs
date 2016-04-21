using _421FinalProject.Machine;
using _421FinalProject.Orders;

namespace _421FinalProject.Employee {
    interface EmployeeIF
    {
        DonutIF prepareDonut(DonutMachine dm);
        CoffeeIF prepareCoffee(CoffeeMachine cm);
        void getNewOrder(Order o);
        Order handleOrder();
    }
}
