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
        public F_syain()
        {
            InitializeComponent();
        }

        private void fncAllSelect()
        {

            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                foreach (var p in context.M_Employees)
                {
                    dataGridViewDsp.Rows.Add(p.EmID, p.EmName, p.SoID, p.PoID, p.EmHiredate, p.EmPhone, p.EmPassword, p.EmFlag, p.EmHidden);
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
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxEmName.Text.Trim()))
                if(textBoxEmName.TextLength > 50)
                {
                    MessageBox.Show("社員名は50文字以下です");
                    return;
                }
            if(!string.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                if(textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字以下です");
                    return;
                }
            if(!string.IsNullOrEmpty(textBoxPoID.Text.Trim()))
                if(textBoxPoID.TextLength > 2)
                {
                    MessageBox.Show("役職IDは2文字以下です");
                    return;
                }
            if(!string.IsNullOrEmpty(textBoxEmPassWord.Text.Trim()))
                if(textBoxEmPassWord.TextLength > 10)
                {
                    MessageBox.Show("パスワードは10文字以下です");
                    return;
                }
            if(!string.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
                if(textBoxEmPhone.TextLength >13)
                {
                    MessageBox.Show("電話番号は13文字以下です");
                    return;
                }
            if(!string.IsNullOrEmpty(textBoxhidden.Text.Trim()))
                if(textBoxhidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
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
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
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
            textBoxSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxPoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
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
                employees.SoID = int.Parse(textBoxSoID.Text.Trim());
                employees.PoID = int.Parse(textBoxPoID.Text.Trim());
                employees.EmHiredate = datetimeEmHiredate.Value;
                employees.EmPhone = textBoxEmPhone.Text.Trim();
                employees.EmPassword = textBoxEmPassWord.Text.Trim();
                employees.EmFlag = check;
                employees.EmHidden = textBoxhidden.Text.Trim();
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
                int emid = int.Parse(textBoxEmID.Text);
                var context = new SalesManagement_DevContext();
                var employees = context.M_Employees.Single(x => x.EmID == emid);
                context.M_Employees.Remove(employees);
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            int emid = int.Parse(textBoxEmID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var employees = context.M_Employees.Where(x => x.EmID == emid).ToArray();
                dataGridViewDsp.Rows.Add(employees[0].EmID, employees[0].EmName, employees[0].SoID, employees[0].PoID, employees[0].EmHiredate, employees[0].EmPhone, employees[0].EmPassword, employees[0].EmFlag, employees[0].EmHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
