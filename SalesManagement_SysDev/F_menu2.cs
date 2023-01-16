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
    public partial class F_menu2 : Form
    {
        //ログインフォームから変数の内容を共有
        internal static int? position = null;
        internal static string loginname = "";

        public F_menu2()
        {
            InitializeComponent();
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            labelmenuTitle.Text = "管理者メニュー";
            buttonManager.BackColor = Color.SandyBrown;
            buttonSalesStaff.BackColor = Color.FromArgb(128, 64, 0);
            buttonLogisticsStaff.BackColor = Color.FromArgb(128, 64, 0);
            groupBoxManager.Visible = true;
            groupBoxLogisticsStaff.Visible = false;
            groupBoxSalesStaff.Visible = false;
            
        }

        private void buttonSalesStaff_Click(object sender, EventArgs e)
        {
            labelmenuTitle.Text = "営業担当メニュー";
            buttonSalesStaff.BackColor = Color.SandyBrown;
            buttonManager.BackColor = Color.FromArgb(128, 64, 0);
            buttonLogisticsStaff.BackColor = Color.FromArgb(128, 64, 0);
            groupBoxSalesStaff.Visible = true;
            groupBoxManager.Visible = false;
            groupBoxLogisticsStaff.Visible = false;
            
        }

        private void buttonLogisticsStaff_Click(object sender, EventArgs e)
        {
            labelmenuTitle.Text = "物流担当メニュー";
            buttonLogisticsStaff.BackColor = Color.SandyBrown;
            buttonManager.BackColor = Color.FromArgb(128, 64, 0);
            buttonSalesStaff.BackColor = Color.FromArgb(128, 64, 0);
            groupBoxLogisticsStaff.Visible = true;
            groupBoxManager.Visible = false;
            groupBoxSalesStaff.Visible = false;
            
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Form frm = new F_kokyaku();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Form frm = new F_syouhin();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Form frm = new F_syain();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            Form frm = new F_uriage();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            Form frm = new F_zaiko();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form frm = new F_jutyuu();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonChumon_Click(object sender, EventArgs e)
        {
            Form frm = new F_tyuumon();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonArrival_Click(object sender, EventArgs e)
        {
            Form frm = new F_nyuuka();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonShipment_Click(object sender, EventArgs e)
        {
            Form frm = new F_syukka();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonChumon2_Click(object sender, EventArgs e)
        {
            Form frm = new F_tyuumon();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonArrval2_Click(object sender, EventArgs e)
        {
            Form frm = new F_nyuuka();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonWarehousing_Click(object sender, EventArgs e)
        {
            Form frm = new F_nyuuko();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonSyukko_Click(object sender, EventArgs e)
        {
            Form frm = new F_syukko();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonHattyu_Click(object sender, EventArgs e)
        {
            Form frm = new F_hattyu();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ログアウトしてよろしいですか？", "ログアウト確認", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //アプリケーションを終了する
                Application.Exit();
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
        }

        private void F_menu2_Activated(object sender, EventArgs e)
        {
            

        }

        private void F_menu2_Load(object sender, EventArgs e)
        {
            labelLoginName.Text = "ログイン社員名：" + loginname;

            //営業担当
            if (position == 2)
            {
                labelmenuTitle.Text = "営業担当メニュー";
                buttonSalesStaff.BackColor = Color.SandyBrown;
                buttonManager.Enabled = false;
                buttonManager.ForeColor = Color.White;
                buttonLogisticsStaff.Enabled = false;
                buttonLogisticsStaff.ForeColor = Color.White;
                groupBoxManager.Visible = false;
                groupBoxLogisticsStaff.Visible = false;
            }

            //物流担当
            else if (position == 4)
            {
                labelmenuTitle.Text = "物流担当メニュー";
                buttonLogisticsStaff.BackColor = Color.SandyBrown;
                buttonManager.Enabled = false;
                buttonSalesStaff.Enabled = false;
                groupBoxManager.Visible = false;
                groupBoxSalesStaff.Visible = false;
            }

            //管理者
            else if(position == 1)
            {
                labelmenuTitle.Text = "管理者メニュー";
                buttonManager.BackColor = Color.SandyBrown;
                groupBoxLogisticsStaff.Visible = false;
                groupBoxSalesStaff.Visible = false;
            }
        }

        private void F_menu2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
