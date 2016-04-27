using _421FinalProject.Machine;
using _421FinalProject.Orders;
using System;
using System.Collections.Generic;

namespace _421FinalProject.Employee {
    class Employee : EmployeeAC
    {

        public Employee(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        /// <summary>
        ///     Employee if free will preform this action while the donutmachine is not 
        ///     currently in use. The employee will grab one of the orders out of the 
        ///     Order Queue and will begin to make this order. Assuming that this order has
        ///     a donut, then they will need to use this donutMachine to make the item.
        /// </summary>
        /// 
        /// <param name="dm">  
        ///     This takes in the donut so that the employee can use the machine (if available)
        ///     to prepare the donut for the customer based on their order. Which is sent
        ///     to the available employee from the queue of orders that need to be done.
        /// </param>
        /// 
        /// <returns>   
        ///      This returns a DonutIF for the customer.    
        /// </returns>
        public override DonutIF prepareDonut(DonutMachine dm, string type) {

            return dm.makeDonut(type);

        }


        /// <summary>
        ///     Employee, if free, will preform this action while the CoffeeMachine is not 
        ///     currently in use. The employee will grab one of the orders out of the 
        ///     Order Queue and will begin to make this order. Assuming that this order has
        ///     a coffee, then they will need to use this coffeeMachine to make the item.
        /// </summary>
        /// 
        /// <param name="cm">  
        ///     This takes in the coffee so that the employee can use the machine 
        ///     to prepare the coffee for the customer based on their order. Which is sent
        ///     to the available employee from the queue of orders that need to be done.
        /// </param>
        /// 
        /// <returns>   
        ///      This returns a CoffeeIF for the order.    
        /// </returns>
        public override CoffeeIF prepareCoffee(CoffeeMachine cm, string coffeeName, List<string> condimentNameList) {
            throw new NotImplementedException();
            
        }

        /// <summary>
        ///     This is used for the employee so that they can make this order that
        ///     they grabbed. previously from the getNewOrder method.
        /// </summary>
        public override Order handleOrder() {

            //  Grab order from the queue
            currentOrder = new Order(); //  set to queues top order.

            return null;    //  should return the finished order.

        }

    }
}
