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
    public partial class F_nyuuko : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

        //コンボボックス用の社員データ
        private static List<M_Employee> Employee;

        public F_nyuuko()
        {
            InitializeComponent();
        }

        private void SetFormComboBox()
        {
            //社員コンボボックス
            Employee = employeeDataAccess.GetEmployeeDspData();
            comboBoxEmployee.DataSource = Employee;
            comboBoxEmployee.DisplayMember = "EmName";
            comboBoxEmployee.ValueMember = "EmID";
            //社員コンボボックスを読み取り専用
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.SelectedIndex = -1;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void F_nyuuko_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 7;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "入庫ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "発注ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "入庫確認社員ID";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "入庫年月日";
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
            SetFormComboBox();
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Warehousings
                         join t2 in context.M_Employees
                         on t1.EmID equals t2.EmID
                         select new
                         {
                             t1.WaID,
                             t1.HaID,
                             t2.EmName,
                             t1.WaDate,
                             t1.WaShelfFlag,
                             t1.WaFlag,
                             t1.WaHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.WaID, p.HaID, p.EmName, p.WaDate, p.WaShelfFlag, p.WaFlag, p.WaHidden);
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

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxHaID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxHaID.Text.Trim()))
                {
                    MessageBox.Show("発注IDは数値です");
                    textBoxHaID.Focus();
                    return;
                }
                if (textBoxHaID.TextLength > 6)
                {
                    MessageBox.Show("発注IDは6文字以下です");
                    return;
                }
            }
            
            if(comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("入庫確認社員名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxWaHidden.Text.Trim()))
            {
                if (textBoxWaHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }
            int checkWa;
            if (checkBoxWaFlag.Checked == true)
            {
                checkWa = 2;
            }
            else
            {
                checkWa = 0;
            }

            int checkWaState;
            if (checkBoxWaSheifFlag.Checked == true)
            {
                checkWaState = 1;
            }
            else
            {
                checkWaState = 0;
            }

            var context = new SalesManagement_DevContext();
            int waid = int.Parse(textBoxWaID.Text);
            try
            {
                var warehousing = context.T_Warehousings.Single(x => x.WaID == waid);
                warehousing.WaShelfFlag = checkWaState;
                warehousing.WaFlag = checkWa;
                warehousing.WaHidden = textBoxWaHidden.Text;
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxWaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            dateTimePickerWaDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString());

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxWaID.Text = "";
            textBoxHaID.Text = "";
            comboBoxEmployee.Text = "";
            dateTimePickerWaDate.Value = DateTime.Today;
            textBoxWaHidden.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxWaFlag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWaHidden_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
