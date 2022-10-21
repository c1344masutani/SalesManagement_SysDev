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

        private void OutHouse_button_Click(object sender, EventArgs e)
        {

        }
    }
}
