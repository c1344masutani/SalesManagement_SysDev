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
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string stid = string.Empty;
            string prname = string.Empty;
            string price = string.Empty;
            string stquantity = string.Empty;
            if (!String.IsNullOrEmpty(textBoxStID.Text))
            {
                stid = textBoxStID.Text;
            }
            
            if (!String.IsNullOrEmpty(textBoxPrName.Text))
            {
                prname = textBoxPrName.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPrice.Text))
            {
                price = textBoxPrice.Text;
            }
            if (!String.IsNullOrEmpty(textBoxStQuantity.Text))
            {
                stquantity = textBoxStQuantity.Text;
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Stocks
                         join t2 in context.M_Products
                         on t1.PrID equals t2.PrID
                         where t1.StID.ToString().Contains(stid) &&
                               t2.PrName.Contains(prname) &&
                               t2.Price.ToString().Contains(price) &&
                               t1.StQuantity.ToString().Contains(stquantity)
                         select new
                         {
                             t1.StID,
                             t2.PrName,
                             t2.Price,
                             t1.StQuantity,
                             t1.StFlag
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID, p.PrName, p.Price, p.StQuantity,p.StFlag);
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
                         where t1.StFlag == 0
                         select new
                         {
                             t1.StID,
                             t2.PrName,
                             t2.Price,
                             t1.StQuantity,
                             t1.StFlag
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID,p.PrName,p.Price,p.StQuantity,p.StFlag);
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
            dataGridViewDsp.Columns[1].Width = 200;
            dataGridViewDsp.Columns[1].HeaderText = "商品名";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "値段";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "在庫数";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "非表示フラグ";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();

            button_Update.Visible = true;
            buttonHidden.Visible = true;
            button_Search.Visible = false;
            textBoxPrName.Enabled = false;
            textBoxPrice.Enabled = false;
            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStID.Text))
            {
                MessageBox.Show("在庫IDを入力してください");
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
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxPrName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxStQuantity.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void ClearInput()
        {
            textBoxStID.Text = "";
            textBoxPrName.Text = "";
            textBoxPrice.Text = "";
            textBoxStQuantity.Text = "";
            checkBox_StFlag.Checked = false;
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            int flg = 0;
            if(checkBox_StFlag.Checked == true)
            {
                DialogResult result = MessageBox.Show("非表示にしてもよろしいですか？", "非表示確認", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    flg = 2;
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("非表示にチェックを入れてください");
                return;
            }

            try
            {
                int stid = int.Parse(textBoxStID.Text);
                var context = new SalesManagement_DevContext();
                var stock = context.T_Stocks.Single(x => x.StID == stid);
                stock.StFlag = flg;
                context.SaveChanges();
                context.Dispose();
                MessageBox.Show("非表示にしました");
                fncAllSelect();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void buttonUpdateMode_Click(object sender, EventArgs e)
        {
            button_Update.Visible = true;
            buttonHidden.Visible = true;
            button_Search.Visible = false;
            labelRequired1.Visible = true;
            labelRequired2.Visible = true;
            labelRequired3.Visible = true;
            labelRequired4.Visible = true;
            textBoxPrName.Enabled = false;
            textBoxPrice.Enabled = false;
            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }

        private void buttonSearchMode_Click(object sender, EventArgs e)
        {
            button_Update.Visible = false;
            buttonHidden.Visible = false;
            button_Search.Visible = true;
            labelRequired1.Visible = false;
            labelRequired2.Visible = false;
            labelRequired3.Visible = false;
            labelRequired4.Visible = false;
            textBoxPrName.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxStQuantity.Enabled = true;
            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }

        private void F_zaiko_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
