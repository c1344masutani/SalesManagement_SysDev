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

        //コンボボックス用
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();

        private static List<M_SalesOffice> SalesOffice;
        private static List<M_Employee> Employee;
        private static List<M_Client> Client;

        public F_syukko()
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
            dataGridViewDsp.Columns[1].HeaderText = "社員名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "顧客名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "営業所名";
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
            SetFormComboBox();
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Syukkos
                         join t2 in context.M_Employees
                         on t1.EmID equals t2.EmID
                         join t3 in context.M_Clients
                         on t1.ClID equals t3.ClID
                         join t4 in context.M_SalesOffices
                         on t1.SoID equals t4.SoID
                         select new
                         {
                             t1.SyID,
                             t2.EmName,
                             t3.ClName,
                             t4.SoName,
                             t1.OrID,
                             t1.SyDate,
                             t1.SyStateFlag,
                             t1.SyFlag,
                             t1.SyHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SyID, p.EmName, p.ClName, p.SoName, p.OrID, p.SyDate, p.SyStateFlag, p.SyFlag, p.SyHidden);
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
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは数値です");
                    textBoxOrID.Focus();
                    return;
                }
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
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerSyDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());

        }

        private void PriceTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
