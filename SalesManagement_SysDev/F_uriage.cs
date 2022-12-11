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

        //コンボボックス用
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();

        //コンボボックス用のデータ
        private static List<M_SalesOffice> SalesOffice;
        private static List<M_Employee> Employee;
        private static List<M_Client> Client;

        public F_uriage()
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
            dataGridViewDsp.Columns[1].HeaderText = "顧客名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "営業所名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "受注社員名";
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
            SetFormComboBox();
        }


        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Sale
                         join t2 in context.M_Clients
                         on t1.ClID equals t2.ClID
                         join t3 in context.M_SalesOffices
                         on t1.SoID equals t3.SoID
                         join t4 in context.M_Employees
                         on t1.EmID equals t4.EmID
                         select new
                         {
                             t1.SaID,
                             t2.ClName,
                             t3.SoName,
                             t4.EmName,
                             t1.ChID,
                             t1.SaDate,
                             t1.SaFlag,
                             t1.SaHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SaID, p.ClName, p.SoName, p.EmName, p.ChID, p.SaDate, p.SaFlag, p.SaHidden);
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
            dataGridViewDsp.Rows.Clear();
            string said = string.Empty;
            string clid = string.Empty;
            string soid = string.Empty;
            string emid = string.Empty;
            string chid = string.Empty;
            if (!String.IsNullOrEmpty(textBoxSaID.Text.Trim()))
            {
                said = textBoxSaID.Text;
            }
            if(comboBoxClient.SelectedIndex != -1)
            {
                clid = comboBoxClient.SelectedValue.ToString();
            }
            if(comboBoxSalesOffice.SelectedIndex != -1)
            {
                soid = comboBoxSalesOffice.SelectedValue.ToString();
            }
            if(comboBoxEmployee.SelectedIndex != -1)
            {
                emid = comboBoxEmployee.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxChID.Text.Trim()))
            {
                chid = textBoxChID.Text;
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Sale
                         join t2 in context.M_Clients
                         on t1.ClID equals t2.ClID
                         join t3 in context.M_SalesOffices
                         on t1.SoID equals t3.SoID
                         join t4 in context.M_Employees
                         on t1.EmID equals t4.EmID
                         where t1.SaID.ToString().Contains(said) &&
                               t1.ClID.ToString().Contains(clid) &&
                               t1.SoID.ToString().Contains(soid) &&
                               t1.EmID.ToString().Contains(emid) &&
                               t1.ChID.ToString().Contains(chid)
                         select new
                         {
                             t1.SaID,
                             t2.ClName,
                             t3.SoName,
                             t4.EmName,
                             t1.ChID,
                             t1.SaDate,
                             t1.SaFlag,
                             t1.SaHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SaID, p.ClName, p.SoName, p.EmName, p.ChID, p.SaDate, p.SaFlag, p.SaHidden);
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
            textBoxSaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxChID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerSaDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSaID.Text = "";
            textBoxChID.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            comboBoxClient.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;

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
