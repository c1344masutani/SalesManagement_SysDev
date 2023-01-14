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
    public partial class F_syain : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //コンボボックス用
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        PositionDataAccess positionDataAccess = new PositionDataAccess();
        //コンボボックス用のデータ
        private static List<M_SalesOffice> SalesOffice;
        private static List<M_Position> Position;

        //ログインフォームから来たかの判定用
        internal static string from = "";

        public F_syain()
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

            //役職コンボボックス
            Position = positionDataAccess.GetPositionDspData();
            comboBoxPosition.DataSource = Position;
            comboBoxPosition.DisplayMember = "PoName";
            comboBoxPosition.ValueMember = "PoID";
            //読み取り専用
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.SelectedIndex = -1;
        }

        private void fncAllSelect()
        {

            dataGridViewDsp.Rows.Clear();

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Employees
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Positions
                         on t1.PoID equals t3.PoID
                         where t1.EmFlag == 0
                         select new
                         {
                             t1.EmID,
                             t1.EmName,
                             t2.SoName,
                             t3.PoName,
                             t1.EmHiredate,
                             t1.EmPhone,
                             t1.EmPassword,
                             t1.EmFlag,
                             t1.EmHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.EmID, p.EmName, p.SoName, p.PoName, p.EmHiredate, p.EmPhone, p.EmPassword, p.EmFlag, p.EmHidden);
                }

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_employee_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "社員ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "社員名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "役職ID";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "入社年月日";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "電話番号";
            dataGridViewDsp.Columns[6].Width = 130;
            dataGridViewDsp.Columns[6].HeaderText = "パスワード";
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
            if(from == "login")
            {
                Form frm = new F_Login();

                Opacity = 0;
                frm.ShowDialog();

                this.Close();
            }
            else
            {
                Form frm = new F_menu2();

                Opacity = 0;

                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();

                this.Close();
            }
            
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {

                if (textBoxEmName.TextLength > 50)
                {
                    MessageBox.Show("社員名は50文字以下です");
                    textBoxEmName.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("社員名を入力してください");
                return;
            }

            if(comboBoxSalesOffice.SelectedIndex == -1)
            {
                MessageBox.Show("営業所名を選択してください");
                return;
            }

            if(!string.IsNullOrEmpty(textBoxEmPassWord.Text.Trim()))
            {
                if (textBoxEmPassWord.TextLength > 10)
                {
                    MessageBox.Show("パスワードは10文字以下です");
                    textBoxEmPassWord.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("パスワードを入力してください");
                return;
            }

            if(comboBoxPosition.SelectedIndex == -1)
            {
                MessageBox.Show("役職名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                if (textBoxEmPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以下です");
                    textBoxEmPhone.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }
                
            if(!string.IsNullOrEmpty(textBoxhidden.Text.Trim()))
            {
                if (textBoxhidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    textBoxhidden.Focus();
                    return;
                }
            }
                
            int check;
            if (checkBoxEmFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            var employees = new M_Employee
            {
                EmName = textBoxEmName.Text.Trim(),
                SoID = int.Parse(comboBoxSalesOffice.SelectedValue.ToString()),
                PoID = int.Parse(comboBoxPosition.SelectedValue.ToString()),
                EmHiredate = datetimeEmHiredate.Value,
                EmPhone = textBoxEmPhone.Text.Trim(),
                EmPassword = textBoxEmPassWord.Text.Trim(),
                EmFlag = check,
                EmHidden = textBoxhidden.Text.Trim()
            };

            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Employees.Add(employees);
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxEmName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxPosition.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            datetimeEmHiredate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString());
            textBoxEmPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            textBoxEmPassWord.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "0")
            {
                checkBoxEmFlag.Checked = false;
            }
            else if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "2")
            {
                checkBoxEmFlag.Checked = true;
            }
            textBoxhidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {

                if (textBoxEmName.TextLength > 50)
                {
                    MessageBox.Show("社員名は50文字以下です");
                    textBoxEmName.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("社員名を入力してください");
                return;
            }

            if (comboBoxSalesOffice.SelectedIndex == -1)
            {
                MessageBox.Show("営業所名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxEmPassWord.Text.Trim()))
            {
                if (textBoxEmPassWord.TextLength > 10)
                {
                    MessageBox.Show("パスワードは10文字以下です");
                    textBoxEmPassWord.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("パスワードを入力してください");
                return;
            }

            if (comboBoxPosition.SelectedIndex == -1)
            {
                MessageBox.Show("役職名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                if (textBoxEmPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以下です");
                    textBoxEmPhone.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxhidden.Text.Trim()))
            {
                if (textBoxhidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    textBoxhidden.Focus();
                    return;
                }
            }

            int check;
            if (checkBoxEmFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }
            try
            {
                int emid = int.Parse(textBoxEmID.Text);
                var context = new SalesManagement_DevContext();
                var employees = context.M_Employees.Single(x => x.EmID == emid);
                employees.EmName = textBoxEmName.Text.Trim();
                employees.SoID = int.Parse(comboBoxSalesOffice.SelectedValue.ToString());
                employees.PoID = int.Parse(comboBoxPosition.SelectedValue.ToString());
                employees.EmHiredate = datetimeEmHiredate.Value;
                employees.EmPhone = textBoxEmPhone.Text.Trim();
                employees.EmPassword = textBoxEmPassWord.Text.Trim();
                employees.EmFlag = check;
                employees.EmHidden = textBoxhidden.Text.Trim();
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                ClearInput();

                //非表示メッセージ
                if(check == 2)
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string emid = string.Empty;
            string emname = string.Empty;
            string soid = string.Empty;
            string poid = string.Empty;
            string tel = string.Empty;
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                emid = textBoxEmID.Text;
            }
            if (!String.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {
                emname = textBoxEmName.Text;
            }
            if(comboBoxSalesOffice.SelectedIndex != -1)
            {
                soid = comboBoxSalesOffice.SelectedValue.ToString();
            }
            if(comboBoxPosition.SelectedIndex != -1)
            {
                poid = comboBoxPosition.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                tel = textBoxEmPhone.Text;
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Employees
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Positions
                         on t1.PoID equals t3.PoID
                         where t1.EmID.ToString().Contains(emid) &&
                               t1.EmName.Contains(emname) &&
                               t1.SoID.ToString().Contains(soid) &&
                               t1.PoID.ToString().Contains(poid) &&
                               t1.EmPhone.ToString().Contains(tel)
                         select new
                         {
                             t1.EmID,
                             t1.EmName,
                             t2.SoName,
                             t3.PoName,
                             t1.EmHiredate,
                             t1.EmPhone,
                             t1.EmPassword,
                             t1.EmFlag,
                             t1.EmHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.EmID, p.EmName, p.SoName, p.PoName, p.EmHiredate, p.EmPhone, p.EmPassword, p.EmFlag, p.EmHidden);
                }

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new F_eigyousyo();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            textBoxEmID.Text = "";
            textBoxEmName.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            textBoxEmPassWord.Text = "";
            comboBoxPosition.SelectedIndex = -1;
            datetimeEmHiredate.Value = DateTime.Now;
            textBoxEmPhone.Text = "";
            checkBoxEmFlag.Checked = false;
            textBoxhidden.Text = "";
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmID.Text))
            {
                MessageBox.Show("社員IDを入力してください");
                return;
            }

            int flg;
            if (checkBoxEmFlag.Checked == true)
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
                int emid = int.Parse(textBoxEmID.Text);
                var context = new SalesManagement_DevContext();
                var employee = context.M_Employees.Single(x => x.EmID == emid);
                employee.EmFlag = flg;
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
