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
    public partial class F_tyuumon : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        //コンボボックス用
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();

        //コンボボックス用のデータ
        private static List<M_SalesOffice> SalesOffice;
        private static List<M_Employee> Employee;
        private static List<M_Client> Client;

        public F_tyuumon()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetFormComboBox()
        {
            //営業所コンボボックス
            SalesOffice = salesOfficeDataAccess.GetSalesOfficeDspData();
            comboBoxSalesOffice.DataSource = SalesOffice;
            comboBoxSalesOffice.DisplayMember = "SoName";
            comboBoxSalesOffice.ValueMember = "SoID";
            //読み取り専用
            comboBoxSalesOffice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSalesOffice.SelectedIndex = -1;

            //社員コンボボックス
            Employee = employeeDataAccess.GetEmployeeDspData();
            comboBoxEmployee.DataSource = Employee;
            comboBoxEmployee.DisplayMember = "EmName";
            comboBoxEmployee.ValueMember = "EmID";
            //社員コンボボックスを読み取り専用
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.SelectedIndex = -1;

            //顧客コンボボックス
            Client = clientDataAccess.GetClientDspData();
            comboBoxClient.DataSource = Client;
            comboBoxClient.DisplayMember = "ClName";
            comboBoxClient.ValueMember = "ClID";
            //読み取り専用
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void Disp_button_Click(object sender, EventArgs e)
        {

        }

        private void F_tyuumon_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "注文ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "営業所名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "顧客名";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "注文年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "注文確定フラグ";
            dataGridViewDsp.Columns[7].Width = 70;
            dataGridViewDsp.Columns[7].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[8].Width = 200;
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            fncAllSelect();
            SetFormComboBox();
            buttonConfirm.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            comboBoxSalesOffice.Enabled = false;
            comboBoxEmployee.Enabled = false;
            comboBoxClient.Enabled = false;
            textBoxOrid.Enabled = false;
            dateTimePickerChdate.Enabled = false;
            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }


        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Chumons
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         where t1.ChFlag == 0
                         select new
                         {
                             t1.ChID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t1.OrID,
                             t1.ChDate,
                             t1.ChStateFlag,
                             t1.ChFlag,
                             t1.ChHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ChID,p.SoName,p.EmName,p.ClName,p.OrID,p.ChDate,p.ChStateFlag,p.ChFlag,p.ChHidden);
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
            string chid = string.Empty;
            string soid = string.Empty;
            string emid = string.Empty;
            string clid = string.Empty;
            string orid = string.Empty;
            if (!String.IsNullOrEmpty(textBoxChid.Text.Trim()))
            {
                chid = textBoxChid.Text;
            }
            if(comboBoxSalesOffice.SelectedIndex != -1)
            {
                soid = comboBoxSalesOffice.SelectedValue.ToString();
            }
            if(comboBoxEmployee.SelectedIndex != -1)
            {
                emid = comboBoxEmployee.SelectedValue.ToString();
            }
            if(comboBoxClient.SelectedIndex != -1)
            {
                clid = comboBoxClient.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxOrid.Text.Trim()))
            {
                orid = textBoxOrid.Text;
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Chumons
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         where t1.ChID.ToString().Contains(chid) &&
                               t1.SoID.ToString().Contains(soid) &&
                               t1.EmID.ToString().Contains(emid) &&
                               t1.ClID.ToString().Contains(clid) &&
                               t1.OrID.ToString().Contains(orid) &&
                               t1.ChFlag == 0
                         select new
                         {
                             t1.ChID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t1.OrID,
                             t1.ChDate,
                             t1.ChStateFlag,
                             t1.ChFlag,
                             t1.ChHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ChID, p.SoName, p.EmName, p.ClName, p.OrID, p.ChDate, p.ChStateFlag, p.ChFlag, p.ChHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxChid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerChdate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString() == "1")
            {
                checkBoxChStateflg.Checked = true;
            }
            else
            {
                checkBoxChStateflg.Checked = false;
            }
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "2")
            {
                checkBoxChflg.Checked = true;
            }
            else
            {
                checkBoxChflg.Checked = false;
            }
            textBoxChHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            fncAllSelect();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxChid.Text))
            {
                MessageBox.Show("注文IDを入力してください");
                return;
            }

            var context = new SalesManagement_DevContext();
            int chid = int.Parse(textBoxChid.Text);
            int flg = 0;
            if (checkBoxChStateflg.Checked == true)
            {
                DialogResult result = MessageBox.Show("注文を確定してもよろしいですか", "注文確定確認", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    flg = 1;
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("注文確定にチェックを入れてください");
                return;
            }

            try
            {
                //注文テーブルの確定フラグを１に
                var chumon = context.T_Chumons.Single(x => x.ChID == chid);
                chumon.ChStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //在庫数を減らす
            try
            {
                //注文詳細の商品IDを取得
                var chumondetail = context.T_ChumonDetails.Single(x => x.ChID == chid);
                var stock = context.T_Stocks.Single(x => x.PrID == chumondetail.PrID);
                //在庫数から注文数を引く
                stock.StQuantity = stock.StQuantity - chumondetail.ChQuantity;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出庫テーブル・出庫詳細テーブルにデータを追加
            try
            {
                var chumon = context.T_Chumons.Single(x => x.ChID == chid);
                var chumondetail = context.T_ChumonDetails.Single(x => x.ChID == chid);
                //出庫テーブルに追加
                var syukko = new T_Syukko
                {
                    EmID = chumon.EmID,
                    ClID = chumon.ClID,
                    SoID = chumon.SoID,
                    OrID = chumon.OrID,
                    SyDate = null,
                    SyStateFlag = 0,
                    SyFlag = 0,
                    SyHidden = ""
                };
                context.T_Syukkos.Add(syukko);
                context.SaveChanges();

                var syukkodetail = new T_SyukkoDetail
                {
                    SyID = syukko.SyID,
                    PrID = chumondetail.PrID,
                    SyQuantity = chumondetail.ChQuantity
                };
                context.T_SyukkoDetails.Add(syukkodetail);
                context.SaveChanges();
                ClearInput();
                fncAllSelect();
                MessageBox.Show("注文を確定しました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            context.Dispose();
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxChid.Text))
            {
                MessageBox.Show("注文IDを入力してください");
                return;
            }

            int flg = 0;
            if (checkBoxChflg.Checked == true)
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
                MessageBox.Show("非表示にチェックを入れてください。");
                return;
            }

            try
            {
                int chid = int.Parse(textBoxChid.Text);
                var context = new SalesManagement_DevContext();
                var chumon = context.T_Chumons.Single(x => x.ChID == chid);
                chumon.ChFlag = flg;
                context.SaveChanges();
                context.Dispose();
                MessageBox.Show("非表示にしました");
                ClearInput();
                fncAllSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            textBoxChid.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxClient.SelectedIndex = -1;
            textBoxOrid.Text = "";
            dateTimePickerChdate.Value = DateTime.Today;
            checkBoxChStateflg.Checked = false;
            checkBoxChflg.Checked = false;
            textBoxChHidden.Text = "";
        }

        private void checkBoxChStateflg_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxChStateflg.Checked == true)
            {
                comboBoxClient.Enabled = false;
                comboBoxEmployee.Enabled = false;
                comboBoxSalesOffice.Enabled = false;
                textBoxOrid.Enabled = false;
            }
            else
            {
                comboBoxClient.Enabled = true;
                comboBoxEmployee.Enabled = true;
                comboBoxSalesOffice.Enabled = true;
                textBoxOrid.Enabled = true;
            }
        }

        private void buttonUpdateMode_Click(object sender, EventArgs e)
        {
            buttonConfirm.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            comboBoxSalesOffice.Enabled = false;
            comboBoxEmployee.Enabled = false;
            comboBoxClient.Enabled = false;
            textBoxOrid.Enabled = false;
            dateTimePickerChdate.Enabled = false;
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
            buttonConfirm.Visible = false;
            buttonSearch.Visible = true;
            buttonHidden.Visible = false;
            comboBoxSalesOffice.Enabled = true;
            comboBoxEmployee.Enabled = true;
            comboBoxClient.Enabled = true;
            textBoxOrid.Enabled = true;
            dateTimePickerChdate.Enabled = true;
            labelRequired1.Visible = false;
            labelRequired2.Visible = false;
            labelRequired3.Visible = false;
            labelRequired4.Visible = false;
            labelRequired5.Visible = false;
            labelRequired6.Visible = false;
            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }

        private void F_tyuumon_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
