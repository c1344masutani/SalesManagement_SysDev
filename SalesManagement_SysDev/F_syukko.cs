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
    public partial class F_syukko : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_syukko()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void F_syukko_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "出庫ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "社員ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "出庫年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "出庫確定フラグ";
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
                foreach (var p in context.T_Syukkos)
                {
                    dataGridViewDsp.Rows.Add(p.SyID, p.EmID, p.ClID, p.SoID, p.OrID, p.SyDate, p.SyStateFlag, p.SyFlag, p.SyHidden);
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

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

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
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

            if (!String.IsNullOrEmpty(textBoxSyHidden.Text.Trim()))
            {
                if (textBoxSyHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            var context = new SalesManagement_DevContext();
            int syid = int.Parse(textBoxSyID.Text);
            int flg;
            if (checkBoxSyStateFlag.Checked == true)
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
                //注文テーブルの確定フラグを１に
                var syukko = context.T_Syukkos.Single(x => x.SyID == syid);
                syukko.SyStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //入荷・入荷詳細テーブルにデータを追加
            try
            {
                var syukko = context.T_Syukkos.Single(x => x.SyID == syid);
                var syukkodetail = context.T_SyukkoDetails.Single(x => x.SyID == syid);
                
                //入荷テーブルに追加
                var arrival = new T_Arrival
                {
                    SoID = syukko.SoID,
                    EmID = syukko.EmID,
                    ClID = syukko.ClID,
                    OrID = syukko.OrID,
                    ArDate = syukko.SyDate,
                    ArStateFlag = 0,
                    ArFlag = 0,
                    ArHidden = ""
                };
                context.T_Arrivals.Add(arrival);
                context.SaveChanges();

                //入荷詳細テーブルに追加
                var arrivaldetail = new T_ArrivalDetail
                {
                    ArID = arrival.ArID,
                    PrID = syukkodetail.PrID,
                    ArQuantity = syukkodetail.SyQuantity
                };
                context.T_ArrivalDetails.Add(arrivaldetail);
                context.SaveChanges();
                MessageBox.Show("出庫を確定しました");
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
            if (checkBoxSyFlg.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int syid = int.Parse(textBoxSyID.Text);
                var context = new SalesManagement_DevContext();
                var syukko = context.T_Syukkos.Single(x => x.SyID == syid);
                syukko.SyFlag = flg;
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
            textBoxSyID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerSyDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());

        }
    }
}
