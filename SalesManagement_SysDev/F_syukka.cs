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
    public partial class F_syukka : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_syukka()
        {
            InitializeComponent();
        }

        private void F_syukka_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "出荷ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "出荷完了年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "出荷確定フラグ";
            dataGridViewDsp.Columns[7].Width = 70;
            dataGridViewDsp.Columns[7].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[8].Width = 200;
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                foreach (var p in context.T_Shipments)
                {
                    dataGridViewDsp.Rows.Add(p.ShID, p.ClID, p.EmID, p.SoID, p.OrID, p.ShFinishDate, p.ShStateFlag, p.ShFlag, p.ShHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //非表示機能
            try
            {
                DataGridViewRow row = dataGridViewDsp.Rows.Cast<DataGridViewRow>().First(r => r.Cells[7].Value.ToString() == "2");
                row.Visible = false;
            }
            catch (Exception ex)
            {
                // 該当データなし時は、例外が発生する
                //MessageBox.Show(ex.Message);
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは数値です");
                    textBoxClID.Focus();
                    return;
                }
                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("顧客IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは数値です");
                    textBoxEmID.Focus();
                    return;
                }
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("社員IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは数値です");
                    textBoxSoID.Focus();
                    return;
                }
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは数値です");
                    textBoxOrID.Focus();
                    return;
                }
                if (textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("受注IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxShHidden.Text.Trim()))
            {
                if (textBoxShHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            dataGridViewDsp.Rows.Clear();
            if (textBoxShID.Text == "" || textBoxShID.Text == null)
            {
                fncAllSelect();
                return;
            }

            int shid = int.Parse(textBoxShID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var shipment = context.T_Shipments.Where(x => x.ShID == shid).ToArray();
                dataGridViewDsp.Rows.Add(shipment[0].ShID, shipment[0].ClID, shipment[0].EmID, shipment[0].SoID, shipment[0].OrID, shipment[0].ShFinishDate, shipment[0].ShStateFlag, shipment[0].ShFlag, shipment[0].ShHidden);
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
            {
                MessageBox.Show("顧客IDは数値です");
                textBoxClID.Focus();
                return;
            }
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("顧客IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは数値です");
                    textBoxEmID.Focus();
                    return;
                }
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("社員IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは数値です");
                    textBoxSoID.Focus();
                    return;
                }
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは数値です");
                    textBoxOrID.Focus();
                    return;
                }
                if (textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("受注IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxShHidden.Text.Trim()))
            {
                if (textBoxShHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            var context = new SalesManagement_DevContext();
            int shid = int.Parse(textBoxShID.Text);
            int flg;
            if (checkBoxShStateFlag.Checked == true)
            {
                flg = 1;
            }
            else
            {
                flg = 0;
                return;
            }

            try
            {
                //出荷テーブルの確定フラグを１に
                var shipment = context.T_Shipments.Single(x => x.ShID == shid);
                shipment.ShStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //  売上テーブルにデータを追加
            try
            {
                var shipment = context.T_Shipments.Single(x => x.ShID == shid);
                var shipmentdetail = context.T_ShipmentDetails.Single(x => x.ShID == shid);
                var chumon = context.T_Chumons.Single(x => x.OrID == shipment.OrID);
                var chumondetail = context.T_ChumonDetails.Single(x => x.ChID == chumon.ChID);
                var product = context.M_Products.Single(x => x.PrID == shipmentdetail.PrID);

                //売上テーブルに追加
                var sale = new T_Sale
                {
                    ClID = shipment.ClID,
                    SoID = shipment.SoID,
                    EmID = shipment.EmID,
                    ChID = chumon.ChID,
                    SaDate = DateTime.Today,
                    SaFlag = 0,
                    SaHidden = ""
                };
                context.T_Sale.Add(sale);
                context.SaveChanges();

                //売上詳細テーブルに追加
                var salementdetail = new T_SaleDetail
                {
                    SaID = sale.SaID,
                    PrID = chumondetail.PrID,
                    SaQuantity = chumondetail.ChQuantity,
                    SaPrTotalPrice = product.Price * chumondetail.ChQuantity
                };
                context.T_ShipmentDetails.Add(shipmentdetail);
                context.SaveChanges();
                MessageBox.Show("出荷を確定しました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            context.Dispose();
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            int flg;
            if (checkBoxShFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int shid = int.Parse(textBoxShID.Text);
                var context = new SalesManagement_DevContext();
                var shipment = context.T_Shipments.Single(x => x.ShID == shid);
                shipment.ShFlag = flg;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxShID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerShFinishDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxShID.Text = "";
            textBoxClID.Text = "";
            textBoxEmID.Text = "";
            textBoxSoID.Text = "";
            textBoxOrID.Text = "";
            dateTimePickerShFinishDate.Value = DateTime.Today;
        }
    }
}
