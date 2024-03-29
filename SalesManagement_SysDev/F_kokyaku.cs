﻿using System;
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
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();


        //コンボボックス用
        private static List<M_SalesOffice> SalesOffices;
        public F_kokyaku()
        {
            InitializeComponent();
        }

        private void SetFormComboBox()
        {
            SalesOffices = salesOfficeDataAccess.GetSalesOfficeDspData();
            comboBoxSalesOffice.DataSource = SalesOffices;
            comboBoxSalesOffice.DisplayMember = "SoName";
            comboBoxSalesOffice.ValueMember = "SoID";
            comboBoxSalesOffice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSalesOffice.SelectedIndex = -1;
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(textBoxClientName.Text.Trim()))
            {
                if (textBoxClientName.TextLength > 50)
                {
                    MessageBox.Show("顧客名は50文字以下です");
                    textBoxClientName.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("顧客名を入力してください");
                return;
            }

            if(comboBoxSalesOffice.SelectedIndex == -1)
            {
                MessageBox.Show("営業所を選択してください");
                return;
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
            else
            {
                MessageBox.Show("住所を入力してください");
                return;
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
            else
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPostnumber.Text.Trim()))
            {
                if (textBoxPostnumber.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以下です");
                    textBoxPostnumber.Focus();
                    return;
                }

                if (!dataInputFormCheck.CheckNumeric(textBoxPostnumber.Text))
                {
                    MessageBox.Show("郵便番号は数値で入力してください");
                    return;
                }
            }
            else
            {
                MessageBox.Show("郵便番号を入力してください");
                return;
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

                SoID = int.Parse(comboBoxSalesOffice.SelectedValue.ToString()),
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
            if (String.IsNullOrEmpty(textBoxClientID.Text.Trim()))
            {
                MessageBox.Show("顧客IDを入力してください");
                return;
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
            else
            {
                MessageBox.Show("顧客名を入力してください");
                return;
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
            else
            {
                MessageBox.Show("住所を入力してください");
                return;
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
            else
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPostnumber.Text.Trim()))
            {
                if (textBoxPostnumber.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以下です");
                    textBoxPostnumber.Focus();
                    return;
                }

                if (!dataInputFormCheck.CheckNumeric(textBoxPostnumber.Text))
                {
                    MessageBox.Show("郵便番号は数値で入力してください");
                    return;
                }
            }
            else
            {
                MessageBox.Show("郵便番号を入力してください");
                return;
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


            
            try
            {
                int clid = int.Parse(textBoxClientID.Text);
                var context = new SalesManagement_DevContext();
                var client = context.M_Clients.Single(x => x.ClID == clid);
                client.SoID = int.Parse(comboBoxSalesOffice.SelectedValue.ToString());
                client.ClName = textBoxClientName.Text.Trim();
                client.ClAddress = textBoxAddress.Text.Trim();
                client.ClPhone = textBoxPhone.Text.Trim();
                client.ClPostal = textBoxPostnumber.Text.Trim();
                client.ClFAX = textBoxFAX.Text.Trim();
                client.ClFlag = 0;
                client.ClHidden = textBoxHidden.Text.Trim();
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Clients
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         where t1.ClFlag == 0
                         select new
                         {
                             t1.ClID,
                             t2.SoName,
                             t1.ClName,
                             t1.ClAddress,
                             t1.ClPhone,
                             t1.ClPostal,
                             t1.ClFAX,
                             t1.ClFlag,
                             t1.ClHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ClID, p.SoName, p.ClName, p.ClAddress, p.ClPhone, p.ClPostal, p.ClFAX, p.ClFlag, p.ClHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string clid = string.Empty;
            string soid = string.Empty;
            string clname = string.Empty;
            string clpostal = string.Empty;
            string address = string.Empty;
            string phone = string.Empty;
            string fax = string.Empty;

            if (!String.IsNullOrEmpty(textBoxClientID.Text.Trim()))
            {
                clid = textBoxClientID.Text;
            }
            if(comboBoxSalesOffice.SelectedIndex != -1)
            {
                soid = comboBoxSalesOffice.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxClientName.Text.Trim()))
            {
                clname = textBoxClientName.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPostnumber.Text.Trim()))
            {
                clpostal = textBoxPostnumber.Text;
            }
            if (!String.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                address = textBoxAddress.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                phone = textBoxPhone.Text;
            }
            if (!String.IsNullOrEmpty(textBoxFAX.Text.Trim()))
            {
                fax = textBoxFAX.Text;
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Clients
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         where t1.ClID.ToString().Contains(clid) &&
                               t2.SoID.ToString().Contains(soid) &&
                               t1.ClName.Contains(clname) &&
                               t1.ClAddress.Contains(address) &&
                               t1.ClPhone.Contains(phone) &&
                               t1.ClPostal.Contains(clpostal) &&
                               t1.ClFAX.Contains(fax) &&
                               t1.ClFlag == 0
                         select new
                         {
                             t1.ClID,
                             t2.SoName,
                             t1.ClName,
                             t1.ClAddress,
                             t1.ClPhone,
                             t1.ClPostal,
                             t1.ClFAX,
                             t1.ClFlag,
                             t1.ClHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ClID, p.SoName, p.ClName, p.ClAddress, p.ClPhone, p.ClPostal, p.ClFAX, p.ClFlag, p.ClHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void client_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "営業所名";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "顧客名";
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[3].HeaderText = "住所";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "電話番号";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "郵便番号";
            dataGridViewDsp.Columns[6].Width = 130;
            dataGridViewDsp.Columns[6].HeaderText = "FAX番号";
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
            SetFormComboBox();

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
            labelRequired7.Visible = true;

            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxClientID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
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

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearInput();
            fncAllSelect();
        }

        private void ClearInput()
        {
            textBoxClientID.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            textBoxClientName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxPostnumber.Text = "";
            textBoxFAX.Text = "";
            textBoxHidden.Text = "";
            checkBoxClflg.Checked = false;
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxClientID.Text))
            {
                MessageBox.Show("顧客IDを入力してください");
                return;
            }

            int flg = 0;
            if (checkBoxClflg.Checked == true)
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
                int clid = int.Parse(textBoxClientID.Text);
                var context = new SalesManagement_DevContext();
                var client = context.M_Clients.Single(x => x.ClID == clid);
                client.ClFlag = flg;
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
            labelRequired7.Visible = true;

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
            labelRequired7.Visible = false;

            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }
    }
}
