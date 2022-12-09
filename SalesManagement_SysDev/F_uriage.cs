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
    public partial class F_uriage : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_uriage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void F_uriage_Load(object sender, EventArgs e)
        {
            dataGridViewDsp.ColumnCount = 8;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "売上ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "受注社員ID";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "売上日時";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[7].Width = 200;
            dataGridViewDsp.Columns[7].HeaderText = "非表示理由";
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
                foreach (var p in context.T_Sale)
                {
                    dataGridViewDsp.Rows.Add(p.SaID,p.ClID,p.SoID,p.EmID,p.ChID,p.SaDate,p.SaFlag,p.SaHidden);
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
                DataGridViewRow row = dataGridViewDsp.Rows.Cast<DataGridViewRow>().First(r => r.Cells[6].Value.ToString() == "2");
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
                if (textBoxClID.TextLength > 4)
                {
                    MessageBox.Show("顧客IDは4文字以下です");
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

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("受注社員IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxChID.Text.Trim()))
            {
                if (textBoxChID.TextLength > 6)
                {
                    MessageBox.Show("受注IDは6文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxSaHidden.Text.Trim()))
            {
                if (textBoxSaHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }
            dataGridViewDsp.Rows.Clear();
            if (textBoxSaID.Text == "" || textBoxSaID.Text == null)
            {
                fncAllSelect();
                return;
            }

            int said = int.Parse(textBoxSaID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var sale = context.T_Sale.Where(x => x.SaID == said).ToArray();
                dataGridViewDsp.Rows.Add(sale[0].SaID, sale[0].ClID, sale[0].SoID, sale[0].EmID, sale[0].ChID, sale[0].SaDate, sale[0].SaFlag, sale[0].SaHidden);
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxChID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerSaDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSaID.Text = "";
            textBoxClID.Text = "";
            textBoxSoID.Text = "";
            textBoxEmID.Text = "";
            textBoxChID.Text = "";
            dateTimePickerSaDate.Value = DateTime.Today;
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            int flg;
            if(checkBoxSaFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int said = int.Parse(textBoxSaID.Text);
                var context = new SalesManagement_DevContext();
                var sale = context.T_Sale.Single(x => x.SaID == said);
                sale.SaFlag = flg;
                context.SaveChanges();
                context.Dispose();
                MessageBox.Show("非表示にしました");
                fncAllSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
