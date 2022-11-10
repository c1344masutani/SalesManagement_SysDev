using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_menu : Form
    {
        public F_menu()
        {
            InitializeComponent();
        }

        private void Customer_button_Click(object sender, EventArgs e)
        {
            Form frm = new client();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Goods_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_product();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Stock_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_stock();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Member_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_employee();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Profit_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_sale();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Received_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_order_received();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }
    }
}
