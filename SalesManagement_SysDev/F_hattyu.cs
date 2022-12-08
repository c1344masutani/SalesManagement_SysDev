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
    public partial class F_hattyu : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_hattyu()
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

        private void F_hattyu_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 7;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "発注ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "メーカID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "発注社員ID";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "発注年月日";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "入庫済みフラグ";
            dataGridViewDsp.Columns[5].Width = 70;
            dataGridViewDsp.Columns[5].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[6].Width = 200;
            dataGridViewDsp.Columns[6].HeaderText = "非表示理由";
            
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
                foreach (var p in context.T_Hattyus)
                {
                    dataGridViewDsp.Rows.Add(p.HaID,p.MaID,p.EmID,p.HaDate,p.WaWarehouseFlag,p.HaFlag,p.HaHidden);
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
                DataGridViewRow row = dataGridViewDsp.Rows.Cast<DataGridViewRow>().First(r => r.Cells[5].Value.ToString() == "2");
                row.Visible = false;
            }
            catch (Exception ex)
            {
                // 該当データなし時は、例外が発生する
                //MessageBox.Show(ex.Message);
            }
        }

        private void button_touroku_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
            {
                if (textBoxMaID.TextLength > 4)
                {
                    MessageBox.Show("メーカーは4文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("発注社員IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxHaHidden.Text.Trim()))
            {
                if (textBoxHaHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            int check;
            if(checkBoxHaFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            int check_nyuko;
            if(checkBoxWaWarehouseFlag.Checked == true)
            {
                check_nyuko = 1;
            }
            else
            {
                check_nyuko = 0;
            }

            var hattyu = new T_Hattyu
            {
                MaID = int.Parse(textBoxMaID.Text),
                EmID = int.Parse(textBoxEmID.Text),
                HaDate = dateTimePickerHaDate.Value,
                WaWarehouseFlag = check_nyuko,
                HaFlag = check,
                HaHidden = textBoxHaHidden.Text
            };

            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Hattyus.Add(hattyu);
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            dateTimePickerHaDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString());
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString() == "1")
            {
                checkBoxWaWarehouseFlag.Checked = true;
            }
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString() == "2")
            {
                checkBoxHaFlag.Checked = true;
            }
            textBoxHaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void button_koushin_Click(object sender, EventArgs e)
        {
            int check;
            if (checkBoxHaFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            int check_nyuko;
            if (checkBoxWaWarehouseFlag.Checked == true)
            {
                check_nyuko = 1;
            }
            else
            {
                check_nyuko = 0;
            }

            try
            {
                int haid = int.Parse(textBoxHaID.Text);
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Single(x => x.HaID == haid);
                hattyu.MaID = int.Parse(textBoxMaID.Text);
                hattyu.EmID = int.Parse(textBoxEmID.Text);
                hattyu.HaDate = dateTimePickerHaDate.Value;
                hattyu.WaWarehouseFlag = check_nyuko;
                hattyu.HaFlag = check;
                hattyu.HaHidden = textBoxHaHidden.Text;
                context.SaveChanges();

                //入庫済みフラグが１の時
                if(hattyu.WaWarehouseFlag == 1)
                {
                    var warehousing = new T_Warehousing
                    {
                        HaID = hattyu.HaID,
                        EmID = hattyu.EmID,
                        WaDate = hattyu.HaDate,
                        WaShelfFlag = 0,
                        WaFlag = 0,
                        WaHidden = ""
                    };

                    try
                    {
                        context.T_Warehousings.Add(warehousing);
                        context.SaveChanges();
                        MessageBox.Show("入庫テーブルにデータを追加しました");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                context.Dispose();
                fncAllSelect();
                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_kensaku_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            if (textBoxHaID.Text == "" || textBoxHaID.Text == null)
            {
                fncAllSelect();
                return;
            }
            int haid = int.Parse(textBoxHaID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Where(x => x.HaID == haid).ToArray();
                dataGridViewDsp.Rows.Add(hattyu[0].HaID,hattyu[0].MaID,hattyu[0].EmID,hattyu[0].HaDate,hattyu[0].WaWarehouseFlag,hattyu[0].HaFlag,hattyu[0].HaHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxHaID.Text = "";
            textBoxMaID.Text = "";
            textBoxEmID.Text = "";
            dateTimePickerHaDate.Value = DateTime.Today;
            textBoxHaHidden.Text = "";
            checkBoxWaWarehouseFlag.Checked = false;
            checkBoxHaFlag.Checked = false;
        }
    }
}
