using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _421FinalProject
{
    public partial class OrderPanel : UserControl
    {
        bool coffee = false;
        bool donut = true;

        PSUBMainForm mainForm;

        public OrderPanel()
        {
            InitializeComponent();
            pnlCoffee.Hide();
        }

        public void setMainForm(PSUBMainForm m) {
            mainForm = m;
        }

        private void btnDonuts_Click(object sender, EventArgs e)
        {

            pnlCoffee.Hide();
            pnlDonut.Show();
            donut = true;
            coffee = false;
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            pnlCoffee.Show();
            pnlDonut.Hide();
            donut = true;
            coffee = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.pnlMain.Show();
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
