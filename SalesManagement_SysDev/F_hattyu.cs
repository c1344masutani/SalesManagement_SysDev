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
    public partial class F_hattyu : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //メーカテーブルアクセス用クラスのインスタンス化
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        //社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

        //コンボボックス用のメーカデータ
        private static List<M_Maker> Maker;
        //コンボボックス用の社員データ
        private static List<M_Employee> Employee;

        public F_hattyu()
        {
            InitializeComponent();
        }

        private void SetFormComboBox()
        {
            //メーカコンボボックス
            Maker = makerDataAccess.GetMakerDspData();
            comboBoxMaker.DataSource = Maker;
            comboBoxMaker.DisplayMember = "MaName";
            comboBoxMaker.ValueMember = "MaID";
            // 商品メーカコンボボックスを読み取り専用
            comboBoxMaker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaker.SelectedIndex = -1;

            //社員コンボボックス
            Employee = employeeDataAccess.GetEmployeeDspData();
            comboBoxEmployee.DataSource = Employee;
            comboBoxEmployee.DisplayMember = "EmName";
            comboBoxEmployee.ValueMember = "EmID";
            //社員コンボボックスを読み取り専用
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.SelectedIndex = -1;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void F_hattyu_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 7;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "発注ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "メーカ名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "発注社員名";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "発注年月日";
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
                var tb = from t1 in context.T_Hattyus
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         select new
                         {
                             t1.HaID,
                             t2.MaName,
                             t3.EmName,
                             t1.HaDate,
                             t1.WaWarehouseFlag,
                             t1.HaFlag,
                             t1.HaHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.HaID, p.MaName, p.EmName, p.HaDate, p.WaWarehouseFlag, p.HaFlag, p.HaHidden);
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

        private void button_touroku_Click(object sender, EventArgs e)
        {
            if(comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカ名を選択してください");
                return;
            }

            if(comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("発注社員名を選択してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxHaHidden.Text.Trim()))
            {
                if (textBoxHaHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            int check;
            if(checkBoxHaFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            int check_nyuko;
            if(checkBoxWaWarehouseFlag.Checked == true)
            {
                check_nyuko = 1;
            }
            else
            {
                check_nyuko = 0;
            }

            var hattyu = new T_Hattyu
            {
                MaID = int.Parse(comboBoxMaker.SelectedValue.ToString()),
                EmID = int.Parse(comboBoxEmployee.SelectedValue.ToString()),
                HaDate = dateTimePickerHaDate.Value,
                WaWarehouseFlag = check_nyuko,
                HaFlag = check,
                HaHidden = textBoxHaHidden.Text
            };

            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Hattyus.Add(hattyu);
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
            textBoxHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxMaker.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            dateTimePickerHaDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString());
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString() == "1")
            {
                checkBoxWaWarehouseFlag.Checked = true;
            }
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString() == "2")
            {
                checkBoxHaFlag.Checked = true;
            }
            textBoxHaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void button_koushin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxHaID.Text))
            {
                MessageBox.Show("発注IDを入力してください");
                return;
            }

            if (comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカ名を選択してください");
                return;
            }

            if (comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("発注社員名を選択してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxHaHidden.Text.Trim()))
            {
                if (textBoxHaHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }
            int check;
            if (checkBoxHaFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            int check_nyuko;
            if (checkBoxWaWarehouseFlag.Checked == true)
            {
                check_nyuko = 1;
            }
            else
            {
                check_nyuko = 0;
            }

            try
            {
                int haid = int.Parse(textBoxHaID.Text);
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Single(x => x.HaID == haid);
                hattyu.MaID = int.Parse(comboBoxMaker.SelectedValue.ToString());
                hattyu.EmID = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                hattyu.HaDate = dateTimePickerHaDate.Value;
                hattyu.WaWarehouseFlag = check_nyuko;
                hattyu.HaFlag = check;
                hattyu.HaHidden = textBoxHaHidden.Text;
                context.SaveChanges();

                //入庫済みフラグが１の時
                if(hattyu.WaWarehouseFlag == 1)
                {
                    var warehousing = new T_Warehousing
                    {
                        HaID = hattyu.HaID,
                        EmID = hattyu.EmID,
                        WaDate = DateTime.Today,
                        WaShelfFlag = 0,
                        WaFlag = 0,
                        WaHidden = ""
                    };

                    try
                    {
                        context.T_Warehousings.Add(warehousing);
                        context.SaveChanges();
                        MessageBox.Show("入庫テーブルにデータを追加しました");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                context.Dispose();
                fncAllSelect();
                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_kensaku_Click(object sender, EventArgs e)
        {
            string haid = string.Empty;
            string maid = string.Empty;
            string emid = string.Empty;
            if (!String.IsNullOrEmpty(textBoxHaID.Text.Trim()))
            {
                haid = textBoxHaID.Text;
            }
            if(comboBoxMaker.SelectedIndex != -1)
            {
                maid = comboBoxMaker.SelectedValue.ToString();
            }
            if(comboBoxEmployee.SelectedIndex != -1)
            {
                emid = comboBoxEmployee.SelectedValue.ToString();
            }

            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Hattyus
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         where t1.HaID.ToString().Contains(haid) &&
                               t1.MaID.ToString().Contains(maid) &&
                               t1.EmID.ToString().Contains(emid) 
                         select new
                         {
                             t1.HaID,
                             t2.MaName,
                             t3.EmName,
                             t1.HaDate,
                             t1.WaWarehouseFlag,
                             t1.HaFlag,
                             t1.HaHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.HaID, p.MaName, p.EmName, p.HaDate, p.WaWarehouseFlag, p.HaFlag, p.HaHidden);
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
            textBoxHaID.Text = "";
            comboBoxMaker.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            dateTimePickerHaDate.Value = DateTime.Today;
            textBoxHaHidden.Text = "";
            checkBoxWaWarehouseFlag.Checked = false;
            checkBoxHaFlag.Checked = false;
        }
    }
}
