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
    public partial class F_jutyuu : Form
    {
        public F_jutyuu()
        {
            InitializeComponent();
        }

        private void F_order_received_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "受注ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "顧客担当者名";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "受注年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "受注確定フラグ";
            dataGridViewDsp.Columns[7].Width = 70;
            dataGridViewDsp.Columns[7].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[8].Width = 200;
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;

            fncAllSelect();
        }


        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                foreach (var p in context.T_Orders)
                {
                    dataGridViewDsp.Rows.Add(p.OrID,p.SoID,p.EmID,p.ClID,p.ClCharge,p.OrDate,p.OrStateFlag,p.OrFlag,p.OrHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
            int checkOr;
            if (checkBoxOrFlag.Checked == true)
            {
                checkOr = 2;
            }
            else
            {
                checkOr = 0;
            }

            int checkOrState;
            if(checkBoxOrStateFlag.Checked == true)
            {
                checkOrState = 2;
            }
            else
            {
                checkOrState = 0;
            }

            var context = new SalesManagement_DevContext();

            //受注テーブルにデータをセット
            var order = new T_Order
            {

                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClCharge.Text.Trim(),
                OrDate = datetimepickerOrDate.Value,
                OrFlag = checkOr,
                OrStateFlag = checkOrState,
                OrHidden = textBoxOrHidden.Text.Trim()
            };

            //受注テーブルに登録
            try
            {
                context.T_Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //商品テーブルから商品情報取得
            int prid = int.Parse(textBoxPrID.Text.Trim());
            
            var product = context.M_Products.Single(x => x.PrID == prid);
            
            //受注詳細テーブルにデータをセット
            var orderdetail = new T_OrderDetail
            {
                OrID = order.OrID,
                PrID = product.PrID,
                OrQuantity = int.Parse(numericUpDownOrQuantity.Value.ToString()),
                OrTotalPrice = product.Price * int.Parse(numericUpDownOrQuantity.Value.ToString())
            };

            //受注詳細テーブルに登録
            try
            {
                context.T_OrderDetails.Add(orderdetail);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("登録完了");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            int checkOr;
            if (checkBoxOrFlag.Checked == true)
            {
                checkOr = 2;
            }
            else
            {
                checkOr = 0;
            }

            int checkOrState;
            if (checkBoxOrStateFlag.Checked == true)
            {
                checkOrState = 2;
            }
            else
            {
                checkOrState = 0;
            }

            try
            {
                int orid = int.Parse(textBoxOrID.Text.Trim());
                var context = new SalesManagement_DevContext();
                //受注テーブル
                var order = context.T_Orders.Single(x => x.OrID == orid);
                order.SoID = int.Parse(textBoxSoID.Text.Trim());
                order.EmID = int.Parse(textBoxEmID.Text.Trim());
                order.ClID = int.Parse(textBoxClID.Text.Trim());
                order.ClCharge = textBoxClCharge.Text.Trim();
                order.OrDate = datetimepickerOrDate.Value;
                order.OrStateFlag = checkOrState;
                order.OrFlag = checkOr;
                order.OrHidden = textBoxOrHidden.Text;

                //受注詳細テーブル
                var orderdetail = context.T_OrderDetails.Single(x => x.OrID == orid);
                //商品テーブルから商品情報取得
                int prid = int.Parse(textBoxPrID.Text.Trim());
                var product = context.M_Products.Single(x => x.PrID == prid);
                orderdetail.PrID = int.Parse(textBoxPrID.Text.Trim());
                orderdetail.OrQuantity = int.Parse(numericUpDownOrQuantity.Value.ToString());
                orderdetail.OrTotalPrice = product.Price * int.Parse(numericUpDownOrQuantity.Value.ToString());
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
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxClCharge.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            datetimepickerOrDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
            textBoxOrHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            if(textBoxOrID.Text == "" || textBoxOrID.Text == null)
            {
                fncAllSelect();
                return;
            }
            int orid = int.Parse(textBoxOrID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var order = context.T_Orders.Where(x => x.OrID == orid).ToArray();
                dataGridViewDsp.Rows.Add(order[0].OrID, order[0].SoID, order[0].EmID, order[0].ClID, order[0].ClCharge, order[0].OrDate, order[0].OrStateFlag, order[0].OrFlag, order[0].OrHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}