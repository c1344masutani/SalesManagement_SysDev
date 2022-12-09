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
    public partial class F_nyuuka : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_nyuuka()
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

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                foreach (var p in context.T_Arrivals)
                {
                    dataGridViewDsp.Rows.Add(p.ArID, p.SoID,p.EmID,p.ClID,p.OrID,p.ArDate,p.ArStateFlag,p.ArFlag,p.ArHidden);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxArID.Text = "";
            textBoxSoID.Text = "";
            textBoxEmID.Text = "";
            textBoxClID.Text = "";
            textBoxOrID.Text = "";
            dateTimePickerArdate.Value = DateTime.Today;
            textBoxArHidden.Text = "";
        }

        private void F_nyuuka_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "入荷ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "入社年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "入荷確定フラグ";
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("社員IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("顧客IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("受注IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxArHidden.Text.Trim()))
            {
                if (textBoxArHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            dataGridViewDsp.Rows.Clear();
            if(textBoxArID.Text == "" || textBoxArID.Text == null)
            {
                fncAllSelect();
                return;
            }

            int arid = int.Parse(textBoxArID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var arrival = context.T_Arrivals.Where(x => x.ArID == arid).ToArray();
                dataGridViewDsp.Rows.Add(arrival[0].ArID, arrival[0].SoID, arrival[0].EmID, arrival[0].ClID, arrival[0].OrID, arrival[0].ArDate, arrival[0].ArStateFlag, arrival[0].ArFlag, arrival[0].ArHidden);
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("社員IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("顧客IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("受注IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxArHidden.Text.Trim()))
            {
                if (textBoxArHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            var context = new SalesManagement_DevContext();
            int arid = int.Parse(textBoxArID.Text);
            int flg;
            if (checkBoxArStateFlag.Checked == true)
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
                //入荷テーブルの確定フラグを１に
                var arrival = context.T_Arrivals.Single(x => x.ArID == arid);
                arrival.ArStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出荷・出荷詳細テーブルにデータを追加
            try
            {
                var arrival = context.T_Arrivals.Single(x => x.ArID == arid);
                var arrivaldetail = context.T_ArrivalDetails.Single(x => x.ArID == arid);

                //出荷テーブルに追加
                var shipment = new T_Shipment
                {
                    ClID = arrival.ClID,
                    EmID = arrival.EmID,
                    SoID = arrival.SoID,
                    OrID = arrival.OrID,
                    ShFinishDate = arrival.ArDate,
                    ShStateFlag = 0,
                    ShFlag = 0,
                    ShHidden = ""
                };
                context.T_Shipments.Add(shipment);
                context.SaveChanges();

                //出荷詳細テーブルに追加
                var shipmentdetail = new T_ShipmentDetail
                {
                    ShID = shipment.ShID,
                    PrID = arrivaldetail.PrID,
                    ShDquantity = arrivaldetail.ArQuantity
                };
                context.T_ShipmentDetails.Add(shipmentdetail);
                context.SaveChanges();
                MessageBox.Show("入荷を確定しました");
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
            if (checkBoxArHidden.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int arid = int.Parse(textBoxArID.Text);
                var context = new SalesManagement_DevContext();
                var arrival = context.T_Arrivals.Single(x => x.ArID == arid);
                arrival.ArFlag = flg;
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
            textBoxArID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerArdate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());

        }
    }
}
