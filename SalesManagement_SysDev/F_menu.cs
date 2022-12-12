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
        //ログインフォームから変数の内容を共有
        internal static int? position = null;
        internal static string loginname = "";


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

        private void F_menu_Activated(object sender, EventArgs e)
        {
            labelLoginName.Text = loginname;

            //営業担当
            if(position == 2)
            {
                buttonClient.Enabled = false;
                buttonClient.BackColor = Color.Gray;
                buttonProduct.Enabled = false;
                buttonProduct.BackColor = Color.Gray;
                buttonEmployee.Enabled = false;
                buttonEmployee.BackColor = Color.Gray;
                buttonSale.Enabled = false;
                buttonSale.BackColor = Color.Gray;
                buttonHattyu.Enabled = false;
                buttonHattyu.BackColor = Color.Gray;
                buttonWarehousing.Enabled = false;
                buttonWarehousing.BackColor = Color.Gray;
                buttonSyukko.Enabled = false;
                buttonWarehousing.BackColor = Color.Gray;
                buttonArrival.Enabled = false;
                buttonArrival.BackColor = Color.Gray;
            }
            //物流担当
            else if(position == 4)
            {
                buttonClient.Enabled = false;
                buttonClient.BackColor = Color.Gray;
                buttonProduct.Enabled = false;
                buttonProduct.BackColor = Color.Gray;
                buttonEmployee.Enabled = false;
                buttonEmployee.BackColor = Color.Gray;
                buttonSale.Enabled = false;
                buttonSale.BackColor = Color.Gray;
                buttonOrder.Enabled = false;
                buttonOrder.BackColor = Color.Gray;
                buttonChumon.Enabled = false;
                buttonChumon.BackColor = Color.Gray;

            }
            
        }
    }
}
