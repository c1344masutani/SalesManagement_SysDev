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
    public partial class F_zaiko : Form
    {
        public F_zaiko()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            int? stid = null;
            int? prid = null;
            string prname = string.Empty;
            int? price = null;
            int? stquantity = null;
            if (!String.IsNullOrEmpty(textBoxStID.Text))
            {
                stid = int.Parse(textBoxStID.Text);
            }
            if (!String.IsNullOrEmpty(textBoxPrID.Text))
            {
                prid = int.Parse(textBoxPrID.Text);
            }
            if (!String.IsNullOrEmpty(textBoxPrName.Text))
            {
                prname = textBoxPrName.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPrice.Text))
            {
                price = int.Parse(textBoxPrice.Text);
            }
            if (!String.IsNullOrEmpty(textBoxStQuantity.Text))
            {
                stquantity = int.Parse(textBoxStQuantity.Text);
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Stocks
                         join t2 in context.M_Products
                         on t1.PrID equals t2.PrID
                         where t1.StID.ToString().Contains(stid.ToString()) ||
                               t1.PrID.ToString().Contains(prid.ToString()) ||
                               t2.PrName.Contains(prname) ||
                               t2.Price.ToString().Contains(price.ToString()) ||
                               t1.StQuantity.ToString().Contains(stquantity.ToString())
                         select new
                         {
                             t1.StID,
                             t1.PrID,
                             t2.PrName,
                             t2.Price,
                             t1.StQuantity
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID, p.PrID, p.PrName, p.Price, p.StQuantity);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Stocks
                         join t2 in context.M_Products
                         on t1.PrID equals t2.PrID
                         select new
                         {
                             t1.StID,
                             t1.PrID,
                             t2.PrName,
                             t2.Price,
                             t1.StQuantity
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID,p.PrID,p.PrName,p.Price,p.StQuantity);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void F_zaiko_Load(object sender, EventArgs e)
        {
            dataGridViewDsp.ColumnCount = 5;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "在庫ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "商品ID";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "値段";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "在庫数";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }
    }
}
