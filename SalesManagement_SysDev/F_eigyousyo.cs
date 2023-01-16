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
    public partial class F_eigyousyo : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_eigyousyo()
        {
            InitializeComponent();
        }

        private void F_eigyousyo_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 8;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "営業所名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "郵便番号";
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[3].HeaderText = "住所";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "電話番号";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "FAX番号";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[7].Width = 200;
            dataGridViewDsp.Columns[7].HeaderText = "非表示理由";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            fncAllSelect();

            buttonRegester.Visible = true;
            buttonUpdate.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            labelRequired1.Visible = true;
            labelRequired2.Visible = true;
            labelRequired3.Visible = true;
            labelRequired4.Visible = true;
            labelRequired5.Visible = true;
            labelRequired6.Visible = true;

            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_SalesOffices
                         where t1.SoFlag == 0
                         select new
                         {
                             t1.SoID,
                             t1.SoName,
                             t1.SoPostal,
                             t1.SoAddress,
                             t1.SoPhone,
                             t1.SoFAX,
                             t1.SoFlag,
                             t1.SoHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SoID, p.SoName, p.SoPostal, p.SoAddress, p.SoPhone, p.SoFAX, p.SoFlag, p.SoHidden);
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
            Form frm = new F_syain();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
            frm.Dispose();
            this.Close();
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSoName.Text))
            {
                if(textBoxSoName.TextLength > 50)
                {
                    MessageBox.Show("営業所名は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("営業所名を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPostal.Text))
            {
                if (textBoxPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以下です");
                    return;
                }

                if (!dataInputFormCheck.CheckNumeric(textBoxPostal.Text))
                {
                    MessageBox.Show("郵便番号は数字で入力してください");
                    return;
                }

            }
            else
            {
                MessageBox.Show("郵便番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxAddress.Text))
            {
                if(textBoxAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("住所を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPhone.Text))
            {
                if(textBoxPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxFax.Text))
            {
                if(textBoxFax.TextLength > 13)
                {
                    MessageBox.Show("FAX番号は13文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("FAX番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxHidden.Text))
            {
                if(textBoxHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            int flg;
            if(checkBoxSoFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            var salesoffice = new M_SalesOffice
            {
                SoName = textBoxSoName.Text,
                SoPostal = textBoxPostal.Text,
                SoAddress = textBoxAddress.Text,
                SoPhone = textBoxPhone.Text,
                SoFAX = textBoxFax.Text,
                SoFlag = flg,
                SoHidden = textBoxHidden.Text
            };

            try
            {
                var context = new SalesManagement_DevContext();
                context.M_SalesOffices.Add(salesoffice);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                ClearInput();
                MessageBox.Show("登録完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSoID.Text))
            {
                MessageBox.Show("営業所IDを入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxSoName.Text))
            {
                if (textBoxSoName.TextLength > 50)
                {
                    MessageBox.Show("営業所名は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("営業所名を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPostal.Text))
            {
                if (textBoxPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以下です");
                    return;
                }

                if (!dataInputFormCheck.CheckNumeric(textBoxPostal.Text))
                {
                    MessageBox.Show("郵便番号は数字で入力してください");
                    return;
                }
            }
            else
            {
                MessageBox.Show("郵便番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxAddress.Text))
            {
                if (textBoxAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("住所を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPhone.Text))
            {
                if (textBoxPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxFax.Text))
            {
                if (textBoxFax.TextLength > 13)
                {
                    MessageBox.Show("FAX番号は13文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("FAX番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxHidden.Text))
            {
                if (textBoxHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }
            int flg;
            if (checkBoxSoFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int soid = int.Parse(textBoxSoID.Text);
                var context = new SalesManagement_DevContext();
                var salesoffice = context.M_SalesOffices.Single(x => x.SoID == soid);
                salesoffice.SoName = textBoxSoName.Text;
                salesoffice.SoPostal = textBoxPostal.Text;
                salesoffice.SoAddress = textBoxAddress.Text;
                salesoffice.SoPhone = textBoxPhone.Text;
                salesoffice.SoFAX = textBoxFax.Text;
                salesoffice.SoFlag = flg;
                salesoffice.SoHidden = textBoxHidden.Text;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                ClearInput();
                //非表示メッセージ
                if(flg == 2)
                {
                    MessageBox.Show("非表示にしました");
                    return;
                }

                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxSoName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxPostal.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            textBoxFax.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            textBoxHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string soid = string.Empty;
            string soname = string.Empty;
            string postal = string.Empty;
            string address = string.Empty;
            string phone = string.Empty;
            string fax = string.Empty;

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                soid = textBoxSoID.Text;
            }
            if (!String.IsNullOrEmpty(textBoxSoName.Text.Trim()))
            {
                soname = textBoxSoName.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPostal.Text.Trim()))
            {
                postal = textBoxPostal.Text;
            }
            if (!String.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                address = textBoxAddress.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                phone = textBoxPhone.Text;
            }
            if (!String.IsNullOrEmpty(textBoxFax.Text.Trim()))
            {
                fax = textBoxFax.Text;
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_SalesOffices
                         where t1.SoID.ToString().Contains(soid) &&
                               t1.SoName.Contains(soname) &&
                               t1.SoPostal.Contains(postal) &&
                               t1.SoAddress.Contains(address) &&
                               t1.SoPhone.Contains(phone) &&
                               t1.SoFAX.Contains(fax)
                         select new
                         {
                             t1.SoID,
                             t1.SoName,
                             t1.SoPostal,
                             t1.SoAddress,
                             t1.SoPhone,
                             t1.SoFAX,
                             t1.SoFlag,
                             t1.SoHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SoID, p.SoName, p.SoPostal, p.SoAddress, p.SoPhone, p.SoFAX, p.SoFlag, p.SoHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSoID.Text))
            {
                MessageBox.Show("営業所IDを入力してください");
                return;
            }

            int flg;
            if(checkBoxSoFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int soid = int.Parse(textBoxSoID.Text);
                var context = new SalesManagement_DevContext();
                var salesoffice = context.M_SalesOffices.Single(x => x.SoID == soid);
                salesoffice.SoFlag = flg;
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

        private void ClearInput()
        {
            textBoxSoID.Text = "";
            textBoxSoName.Text = "";
            textBoxPostal.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxFax.Text = "";
            checkBoxSoFlag.Checked = false;
            textBoxHidden.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            fncAllSelect();
        }

        private void buttonUpdateMode_Click(object sender, EventArgs e)
        {
            buttonRegester.Visible = true;
            buttonUpdate.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            labelRequired1.Visible = true;
            labelRequired2.Visible = true;
            labelRequired3.Visible = true;
            labelRequired4.Visible = true;
            labelRequired5.Visible = true;
            labelRequired6.Visible = true;

            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }

        private void buttonSearchMode_Click(object sender, EventArgs e)
        {
            buttonRegester.Visible = false;
            buttonUpdate.Visible = false;
            buttonHidden.Visible = false;
            buttonSearch.Visible = true;
            labelRequired1.Visible = false;
            labelRequired2.Visible = false;
            labelRequired3.Visible = false;
            labelRequired4.Visible = false;
            labelRequired5.Visible = false;
            labelRequired6.Visible = false;

            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }

        private void F_eigyousyo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
