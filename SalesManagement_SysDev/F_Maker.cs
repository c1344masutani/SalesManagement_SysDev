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
    public partial class F_Maker : Form
    {
        public F_Maker()
        {
            InitializeComponent();
        }

        private void F_Maker_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 8;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "メーカID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "メーカ名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "郵便番号";
            dataGridViewDsp.Columns[3].Width = 130;
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
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Makers
                         where t1.MaFlag == 0
                         select new
                         {
                             t1.MaID,
                             t1.MaName,
                             t1.MaPostal,
                             t1.MaAdress,
                             t1.MaPhone,
                             t1.MaFAX,
                             t1.MaFlag,
                             t1.MaHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.MaID, p.MaName, p.MaPostal, p.MaAdress, p.MaPhone, p.MaFAX, p.MaFlag, p.MaHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxMaName.Text))
            {
                if(textBoxMaName.TextLength > 50)
                {
                    MessageBox.Show("メーカ名は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("メーカ名を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPostal.Text))
            {
                if(textBoxPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7桁以下です");
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
                    MessageBox.Show("電話番号は13桁以下です");
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
                    MessageBox.Show("FAX番号は13桁以下です");
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
            if(checkBoxMaFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            var maker = new M_Maker
            {
                MaName = textBoxMaName.Text,
                MaPostal = textBoxPostal.Text,
                MaAdress = textBoxAddress.Text,
                MaPhone = textBoxPhone.Text,
                MaFAX = textBoxFax.Text,
                MaFlag = flg,
                MaHidden = textBoxHidden.Text
            };

            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Makers.Add(maker);
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
            if (String.IsNullOrEmpty(textBoxMaID.Text))
            {
                MessageBox.Show("メーカIDを入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxMaName.Text))
            {
                if (textBoxMaName.TextLength > 50)
                {
                    MessageBox.Show("メーカ名は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("メーカ名を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPostal.Text))
            {
                if (textBoxPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7桁以下です");
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
                    MessageBox.Show("電話番号は13桁以下です");
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
                    MessageBox.Show("FAX番号は13桁以下です");
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

            

            try
            {
                int maid = int.Parse(textBoxMaID.Text);
                var context = new SalesManagement_DevContext();
                var maker = context.M_Makers.Single(x => x.MaID == maid);
                maker.MaID = int.Parse(textBoxMaID.Text);
                maker.MaName = textBoxMaName.Text;
                maker.MaPostal = textBoxPostal.Text;
                maker.MaAdress = textBoxAddress.Text;
                maker.MaPhone = textBoxPhone.Text;
                maker.MaFAX = textBoxFax.Text;
                maker.MaFlag = 0;
                maker.MaHidden = textBoxHidden.Text;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                ClearInput();
                

                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string maid = string.Empty;
            string maname = string.Empty;
            string postal = string.Empty;
            string address = string.Empty;
            string phone = string.Empty;
            string fax = string.Empty;

            if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
            {
                maid = textBoxMaID.Text;
            }
            if (!String.IsNullOrEmpty(textBoxMaName.Text.Trim()))
            {
                maname = textBoxMaName.Text;
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
                var tb = from t1 in context.M_Makers
                         where t1.MaID.ToString().Contains(maid) &&
                               t1.MaName.Contains(maname) &&
                               t1.MaPostal.Contains(postal) &&
                               t1.MaAdress.Contains(address) &&
                               t1.MaPhone.Contains(phone) &&
                               t1.MaFAX.Contains(fax)
                         select new
                         {
                             t1.MaID,
                             t1.MaName,
                             t1.MaPostal,
                             t1.MaAdress,
                             t1.MaPhone,
                             t1.MaFAX,
                             t1.MaFlag,
                             t1.MaHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.MaID, p.MaName, p.MaPostal, p.MaAdress, p.MaPhone, p.MaFAX, p.MaFlag, p.MaHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form frm = new F_syouhin();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxMaName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxPostal.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            textBoxFax.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString() == "2")
            {
                checkBoxMaFlag.Checked = true;
            }
            else
            {
                checkBoxMaFlag.Checked = false;
            }
            textBoxHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
        }

        private void ClearInput()
        {
            textBoxMaID.Text = "";
            textBoxMaName.Text = "";
            textBoxPostal.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxFax.Text = "";
            checkBoxMaFlag.Checked = false;
            textBoxHidden.Text = "";
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMaID.Text))
            {
                MessageBox.Show("メーカIDを入力してください");
                return;
            }

            int flg;
            if(checkBoxMaFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
                MessageBox.Show("非表示にチェックを入れてください");
                return;
            }

            try
            {
                int maid = int.Parse(textBoxMaID.Text);
                var context = new SalesManagement_DevContext();
                var maker = context.M_Makers.Single(x => x.MaID == maid);
                maker.MaFlag = flg;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                ClearInput();
                MessageBox.Show("非表示にしました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
