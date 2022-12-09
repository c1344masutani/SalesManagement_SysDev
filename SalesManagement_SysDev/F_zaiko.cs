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
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

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

            if (!string.IsNullOrEmpty(textBoxPrID.Text.Trim()))
                if (textBoxPrID.TextLength > 6)
                {

                    if (!dataInputFormCheck.CheckNumeric(textBoxPrID.Text.Trim()))
                    {
                        MessageBox.Show("M5027");
                        textBoxPrID.Focus();
                        return;
                    }

                    MessageBox.Show("商品IDは6文字以下です");
                    return;
                }
            if (!string.IsNullOrEmpty(textBoxStQuantity.Text.Trim()))
                if (textBoxStQuantity.TextLength > 4)
                {

                    if (!dataInputFormCheck.CheckNumeric(textBoxStQuantity.Text.Trim()))
                    {
                        MessageBox.Show("M5027");
                        textBoxStQuantity.Focus();
                        return;
                    }

                    MessageBox.Show("在庫数は4文字以下です");
                    return;
                }
            if (!string.IsNullOrEmpty(textBoxPrName.Text.Trim()))
                if (textBoxPrName.TextLength > 50)
                {

                    if (!dataInputFormCheck.CheckNumeric(textBoxPrName.Text.Trim()))
                    {
                        MessageBox.Show("M5027");
                        textBoxPrName.Focus();
                        return;
                    }

                    MessageBox.Show("商品名は50文字以下です");
                    return;
                }

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
                             t1.StQuantity,
                             t1.StFlag
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID, p.PrID, p.PrName, p.Price, p.StQuantity,p.StFlag);
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
                             t1.StQuantity,
                             t1.StFlag
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID,p.PrID,p.PrName,p.Price,p.StQuantity,p.StFlag);
                }

                

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            try
            {
                DataGridViewRow row = dataGridViewDsp.Rows.Cast<DataGridViewRow>().First(r => r.Cells[5].Value.ToString() == "2");
                row.Visible = false;
            }
            catch (Exception ex)
            {
                // 該当データなし時は、例外が発生する
                //MessageBox.Show(ex.Message);
            }



        }

        private void F_zaiko_Load(object sender, EventArgs e)
        {
            dataGridViewDsp.ColumnCount = 6;
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
            dataGridViewDsp.Columns[5].Width = 70;
            dataGridViewDsp.Columns[5].HeaderText = "非表示フラグ";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxPrID.Text.Trim()))
                if (textBoxPrID.TextLength > 6)
                {
                    MessageBox.Show("商品IDは6文字以下です");
                    return;
                }
            if (!string.IsNullOrEmpty(textBoxStQuantity.Text.Trim()))
                if (textBoxStQuantity.TextLength > 4)
                {
                    MessageBox.Show("在庫数は4文字以下です");
                    return;
                }
            if (!string.IsNullOrEmpty(textBoxPrName.Text.Trim()))
                if (textBoxPrName.TextLength > 50)
                {
                    MessageBox.Show("商品名は50文字以下です");
                    return;
                }
            int flg;
            if(checkBox_StFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int stid = int.Parse(textBoxStID.Text);
                var context = new SalesManagement_DevContext();
                var stock = context.T_Stocks.Single(x => x.StID == stid);
                stock.StQuantity = int.Parse(textBoxStQuantity.Text.Trim());
                stock.StFlag = flg;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxPrName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxStQuantity.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
        }
    }
}
