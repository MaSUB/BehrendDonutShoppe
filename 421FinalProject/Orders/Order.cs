using System.Collections.Generic;

namespace _421FinalProject.Orders {

    public class Order
    {

        private List<Item> ticketItems;
        private double price;

        /// <summary>
        /// The first section of methods here are used to manipulate the 
        /// actual list of items with out exposing the items.
        /// </summary>
        public void addItem(Item i) {
            ticketItems.Add(i);
            addToPrice(i);
        }
        public List<Item> getItems() {
            return ticketItems;
        }
        public void removeItemAt(int i) {
            removeFromPrice(i);
            ticketItems.RemoveAt(i);
        }

        /// <summary>
        ///     These methods are used to maintain the price of the order to be correct.
        /// </summary>
        /// <param name="i">
        ///     addToPrice:         takes in the item that is currently being added to the list.
        ///     removeFromPrice:    takes the index of the item that is being removed.
        /// </param>
        private void addToPrice(Item i) {
            price += i.getPrice();
        }
        private void removeFromPrice(int i) {
            price = price - ticketItems[i].getPrice();
        }
        
        /// <summary>
        ///     Just used to return the price of the order.
        /// </summary>
        public double getPice() {
            return price;
        }

    }
}
