using _421FinalProject.Orders;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace _421FinalProject {
    public partial class PSUBMainForm : Form
    {

        Queue<Order> orderQueue = new Queue<Order>();

        public PSUBMainForm()
        {
            InitializeComponent();
            pnlOrders.setMainForm(this);
            pnlOrders.Hide();
        }

        /// <summary>
        ///     This creates the new order screen. The issue is getting the information back to this window.
        ///     we can easily pass the order list to it but it isnt so easy to pass the information back.
        /// </summary>
        private void btnNewOrder_Click(object sender, System.EventArgs e) {
            //  We are going to have to make some interesting things happen here.

            pnlMain.Hide();
            pnlOrders.Location = pnlMain.Location;
            pnlOrders.Show();

        }
    }
}
