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
    public partial class F_kokyaku : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_kokyaku()
        {
            InitializeComponent();
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSalesOfficeID.Text.Trim()))
            {

                if (!dataInputFormCheck.CheckNumeric(textBoxSalesOfficeID.Text.Trim()))
                {
                    MessageBox.Show("M5027");
                    textBoxSalesOfficeID.Focus();
                    return;
                }

                if(textBoxSalesOfficeID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
                    textBoxSalesOfficeID.Focus();
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxClientName.Text.Trim()))
            {
                if (textBoxClientName.TextLength > 50)
                {
                    MessageBox.Show("顧客名は50文字以下です");
                    textBoxClientName.Focus();
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                if (textBoxAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以下です");
                    textBoxAddress.Focus();
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                if (textBoxPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以下です");
                    textBoxPhone.Focus();
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxPostnumber.Text.Trim()))
            {
                if (textBoxPostnumber.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以下です");
                    textBoxPostnumber.Focus();
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxHidden.Text.Trim()))
            {
                if (textBoxHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    textBoxHidden.Focus();
                    return;
                }
            }

            int check;
            if (checkBoxClflg.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }
            var client = new M_Client
            {

                SoID = int.Parse(textBoxSalesOfficeID.Text.Trim()),
                ClName = textBoxClientName.Text.Trim(),
                ClAddress = textBoxAddress.Text.Trim(),
                ClPhone = textBoxPhone.Text.Trim(),
                ClPostal = textBoxPostnumber.Text.Trim(),
                ClFAX = textBoxFAX.Text.Trim(),
                ClFlag = check,
                ClHidden = textBoxHidden.Text.Trim()

            };
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Clients.Add(client);
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
            int flg;
            if (checkBoxClflg.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }
            try
            {
                int clid = int.Parse(textBoxClientID.Text);
                var context = new SalesManagement_DevContext();
                var client = context.M_Clients.Single(x => x.ClID == clid);
                client.SoID = int.Parse(textBoxSalesOfficeID.Text.Trim());
                client.ClName = textBoxClientName.Text.Trim();
                client.ClAddress = textBoxAddress.Text.Trim();
                client.ClPhone = textBoxPhone.Text.Trim();
                client.ClPostal = textBoxPostnumber.Text.Trim();
                client.ClFAX = textBoxFAX.Text.Trim();
                client.ClFlag = flg;
                client.ClHidden = textBoxHidden.Text.Trim();
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int clid = int.Parse(textBoxClientID.Text);
                var context = new SalesManagement_DevContext();
                var client = context.M_Clients.Single(x => x.ClID == clid);
                context.M_Clients.Remove(client);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("削除完了");
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
                foreach (var p in context.M_Clients)
                {
                    dataGridViewDsp.Rows.Add(p.ClID, p.SoID, p.ClName, p.ClAddress, p.ClPhone, p.ClPostal, p.ClFAX, p.ClFlag, p.ClHidden);
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
            dataGridViewDsp.Rows.Clear();
            if(textBoxClientID.Text == "" || textBoxClientID.Text == null)
            {
                fncAllSelect();
                return;
            }
            int clid = int.Parse(textBoxClientID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var client = context.M_Clients.Where(x => x.ClID == clid).ToArray();
                dataGridViewDsp.Rows.Add(client[0].ClID, client[0].SoID, client[0].ClName, client[0].ClPostal, client[0].ClAddress, client[0].ClPhone, client[0].ClFAX, client[0].ClFlag, client[0].ClHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void client_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "顧客名";
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[3].HeaderText = "住所";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "電話番号";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "郵便番号";
            dataGridViewDsp.Columns[6].Width = 130;
            dataGridViewDsp.Columns[6].HeaderText = "FAX";
            dataGridViewDsp.Columns[7].Width = 70;
            dataGridViewDsp.Columns[7].HeaderText = "顧客管理フラグ";
            dataGridViewDsp.Columns[8].Width = 200;
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxClientID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxSalesOfficeID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxClientName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            textBoxPostnumber.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            textBoxFAX.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "0")
            {
                checkBoxClflg.Checked = false;
            }
            else if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "2")
            {
                checkBoxClflg.Checked = true;
            }
            textBoxHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
        }
    }
}
