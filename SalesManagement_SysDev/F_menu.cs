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
            Form frm = new F_kokyaku();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Goods_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_syouhin();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Stock_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_zaiko();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Member_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_syain();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Profit_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_uriage();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Received_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_jutyuu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_tyuumon();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void HOrder_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_hattyu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void InHouse_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_nyuuko();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void OutHouse_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_syukko();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void InGoods_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_nyuuka();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void OutGoodsbutton_Click(object sender, EventArgs e)
        {
            Form frm = new F_syukka();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("ログアウトしてよろしいですか？", "ログアウト確認", MessageBoxButtons.OKCancel);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //アプリケーションを終了する
                Application.Exit();
            }
            else if(result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            
        }
    }
}
