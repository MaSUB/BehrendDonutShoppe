using System.Collections.Generic;

namespace _421FinalProject.Orders {

    public class Order
    {

        private List<Item> items;
        private double price;
        private string status;

        private List<string> itemStrings;
        private List<List <string>> itemCondimentStrings;

        /// <summary>
        /// The first section of methods here are used to manipulate the 
        /// actual list of items with out exposing the items.
        /// </summary>
        public void addItem(Item i) {
            items.Add(i);
            addToPrice(i);
        }
        public List<Item> getItems() {
            return items;
        }
        public void removeItemAt(int i) {
            removeFromPrice(i);
            items.RemoveAt(i);
        }



        public void addStringItem(string s, List<string> con) {

            if (con == null){
                itemStrings.Add(s);
                List<string> c = new List<string>();
                c.Add("");
                itemCondimentStrings.Add(c);
            }
            else {
                itemStrings.Add(s);
                itemCondimentStrings.Add(con);
            }
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
            price = price - items[i].getPrice();
        }
        
        /// <summary>
        ///     Just used to return the price of the order.
        /// </summary>
        public double getPice() {
            return price;
        }

    }
}
