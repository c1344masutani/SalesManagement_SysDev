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
    public partial class F_nyuuka : Form
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

        public F_nyuuka()
        {
            InitializeComponent();
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

        private void button_back_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

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
                var tb = from t1 in context.T_Arrivals
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         where t1.ArFlag == 0
                         select new
                         {
                             t1.ArID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t1.OrID,
                             t1.ArDate,
                             t1.ArStateFlag,
                             t1.ArFlag,
                             t1.ArHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ArID, p.SoName, p.EmName, p.ClName, p.OrID, p.ArDate, p.ArStateFlag, p.ArFlag, p.ArHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            fncAllSelect();
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
            dataGridViewDsp.Columns[1].HeaderText = "営業所名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "顧客名";
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
            SetFormComboBox();

            buttonConfirm.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            comboBoxClient.Enabled = false;
            comboBoxEmployee.Enabled = false;
            comboBoxSalesOffice.Enabled = false;
            textBoxOrID.Enabled = false;
            labelRequired1.Visible = true;
            labelRequired2.Visible = true;
            labelRequired3.Visible = true;
            labelRequired4.Visible = true;
            labelRequired5.Visible = true;
            labelRequired6.Visible = true;

            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string arid = string.Empty;
            string clid = string.Empty;
            string emid = string.Empty;
            string soid = string.Empty;
            string orid = string.Empty;

            if (!String.IsNullOrEmpty(textBoxArID.Text.Trim()))
            {
                arid = textBoxArID.Text;
            }
            if (comboBoxClient.SelectedIndex != -1)
            {
                clid = comboBoxClient.SelectedValue.ToString();
            }
            if (comboBoxEmployee.SelectedIndex != -1)
            {
                emid = comboBoxEmployee.SelectedValue.ToString();
            }
            if (comboBoxSalesOffice.SelectedIndex != -1)
            {
                soid = comboBoxSalesOffice.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                orid = textBoxOrID.Text;
            }


            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Arrivals
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         where t1.ArID.ToString().Contains(arid) &&
                               t1.SoID.ToString().Contains(soid) &&
                               t1.EmID.ToString().Contains(emid) &&
                               t1.ClID.ToString().Contains(clid) &&
                               t1.OrID.ToString().Contains(orid) && 
                               t1.ArFlag == 0
                         select new
                         {
                             t1.ArID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t1.OrID,
                             t1.ArDate,
                             t1.ArStateFlag,
                             t1.ArFlag,
                             t1.ArHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ArID, p.SoName, p.EmName, p.ClName, p.OrID, p.ArDate, p.ArStateFlag, p.ArFlag, p.ArHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var context = new SalesManagement_DevContext();
            if (String.IsNullOrEmpty(textBoxArID.Text))
            {
                MessageBox.Show("入荷IDを入力してください");
                return;
            }
            int arid = int.Parse(textBoxArID.Text);
            int flg = 0;
            if (checkBoxArStateFlag.Checked == true)
            {
                DialogResult result = MessageBox.Show("入荷を確定してもよろしいですか", "入荷確定確認", MessageBoxButtons.OKCancel);
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

                MessageBox.Show("入荷確定にチェックを入れてください");
                return;
            }

            try
            {
                //入荷テーブルの確定フラグを１に 確定日を登録
                var arrival = context.T_Arrivals.Single(x => x.ArID == arid);
                arrival.ArDate = DateTime.Now;
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
                    ShFinishDate = null,
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
                ClearInput();
                fncAllSelect();
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
            if (String.IsNullOrEmpty(textBoxArID.Text))
            {
                MessageBox.Show("入荷IDを入力してください");
                return;
            }

            int flg = 0;
            if (checkBoxArHidden.Checked == true)
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
                int arid = int.Parse(textBoxArID.Text);
                var context = new SalesManagement_DevContext();
                var arrival = context.T_Arrivals.Single(x => x.ArID == arid);
                arrival.ArFlag = flg;
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxArID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            //dateTimePickerArdate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());

        }

        private void ClearInput()
        {
            textBoxArID.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxClient.SelectedIndex = -1;
            textBoxOrID.Text = "";
            dateTimePickerArdate.Value = DateTime.Today;
            textBoxArHidden.Text = "";
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void checkBoxArStateFlag_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxArStateFlag.Checked == true)
            {
                comboBoxSalesOffice.Enabled = false;
                comboBoxEmployee.Enabled = false;
                comboBoxClient.Enabled = false;
                textBoxOrID.Enabled = false;
                dateTimePickerArdate.Enabled = false;
            }
            else
            {
                comboBoxSalesOffice.Enabled = true;
                comboBoxEmployee.Enabled = true;
                comboBoxClient.Enabled = true;
                textBoxOrID.Enabled = true;
                dateTimePickerArdate.Enabled = true;
            }
        }

        private void buttonUpdateMode_Click(object sender, EventArgs e)
        {
            buttonConfirm.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            comboBoxClient.Enabled = false;
            comboBoxEmployee.Enabled = false;
            comboBoxSalesOffice.Enabled = false;
            textBoxOrID.Enabled = false;
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
            buttonHidden.Visible = false;
            buttonSearch.Visible = true;
            comboBoxClient.Enabled = true;
            comboBoxEmployee.Enabled = true;
            comboBoxSalesOffice.Enabled = true;
            textBoxOrID.Enabled = true;
            labelRequired1.Visible = false;
            labelRequired2.Visible = false;
            labelRequired3.Visible = false;
            labelRequired4.Visible = false;
            labelRequired5.Visible = false;
            labelRequired6.Visible = false;

            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }

        private void F_nyuuka_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
