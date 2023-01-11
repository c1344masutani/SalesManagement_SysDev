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
        //商品
        ProductDataAccess productDataAccess = new ProductDataAccess();

        //コンボボックス用のメーカデータ
        private static List<M_Maker> Maker;
        //コンボボックス用の社員データ
        private static List<M_Employee> Employee;
        //コンボボックス商品
        private static List<M_Product> Product;

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

            //商品コンボボックス
            Product = productDataAccess.GetProductDspData();
            comboBoxProduct.DataSource = Product;
            comboBoxProduct.DisplayMember = "PrName";
            comboBoxProduct.ValueMember = "PrID";
            //読み取り専用
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.SelectedIndex = -1;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void F_hattyu_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "発注ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "メーカ名";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "発注社員名";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "発注年月日";
            dataGridViewDsp.Columns[5].Width = 70;
            dataGridViewDsp.Columns[5].HeaderText = "発注数";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "入庫済みフラグ";
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
            buttonConfirm.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
            labelRequired1.Visible = true;
            labelRequired2.Visible = true;
            labelRequired3.Visible = true;
            labelRequired4.Visible = true;
            labelRequired5.Visible = true;
            labelRequired6.Visible = true;
            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
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
                         join t4 in context.T_HattyuDetails
                         on t1.HaID equals t4.HaID
                         join t5 in context.M_Products
                         on t4.PrID equals t5.PrID
                         where t1.HaFlag == 0
                         select new
                         {
                             t1.HaID,
                             t2.MaName,
                             t5.PrName,
                             t3.EmName,
                             t1.HaDate,
                             t4.HaQuantity,
                             t1.WaWarehouseFlag,
                             t1.HaFlag,
                             t1.HaHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.HaID, p.MaName,p.PrName, p.EmName, p.HaDate,p.HaQuantity, p.WaWarehouseFlag, p.HaFlag, p.HaHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_touroku_Click(object sender, EventArgs e)
        {
            if(comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカ名を選択してください");
                return;
            }

            if(comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("商品名を選択してください");
                return;
            }

            if(comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("発注社員名を選択してください");
                return;
            }

            if (String.IsNullOrEmpty(textBoxHaQuantity.Text))
            {
                MessageBox.Show("発注数を入力してください");
                return;
            }
            else
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxHaQuantity.Text))
                {
                    MessageBox.Show("発注数は数字で入力してください");
                    return;
                }
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

            var context = new SalesManagement_DevContext();

            var hattyu = new T_Hattyu
            {
                MaID = int.Parse(comboBoxMaker.SelectedValue.ToString()),
                EmID = int.Parse(comboBoxEmployee.SelectedValue.ToString()),
                HaDate = dateTimePickerHaDate.Value,
                WaWarehouseFlag = check_nyuko,
                HaFlag = check,
                HaHidden = textBoxHaHidden.Text
            };

            //発注テーブルに追加
            try
            {
                
                context.T_Hattyus.Add(hattyu);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var hattyudetail = new T_HattyuDetail
            {
                HaID = hattyu.HaID,
                PrID = int.Parse(comboBoxProduct.SelectedValue.ToString()),
                HaQuantity = int.Parse(textBoxHaQuantity.Text),

            };

            //発注詳細テーブルに追加
            try
            {
                context.T_HattyuDetails.Add(hattyudetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            context.Dispose();
            fncAllSelect();
            MessageBox.Show("登録完了");
            InputClear();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxMaker.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxProduct.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            dateTimePickerHaDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString());
            textBoxHaQuantity.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString() == "1")
            {
                checkBoxWaWarehouseFlag.Checked = true;
            }
            else if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString() == "0")
            {
                checkBoxWaWarehouseFlag.Checked = false;
            }

            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "2")
            {
                checkBoxHaFlag.Checked = true;
            }
            else if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "0")
            {
                checkBoxHaFlag.Checked = false;
            }

            textBoxHaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
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

            if(comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("商品名を選択してください");
                return;
            }

            if (comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("発注社員名を選択してください");
                return;
            }

            if (String.IsNullOrEmpty(textBoxHaQuantity.Text))
            {
                MessageBox.Show("発注数を入力してください");
                return;
            }
            else
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxHaQuantity.Text))
                {
                    MessageBox.Show("発注数は数字で入力してください");
                    return;
                }
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
                //発注テーブルを更新
                var hattyu = context.T_Hattyus.Single(x => x.HaID == haid);
                hattyu.MaID = int.Parse(comboBoxMaker.SelectedValue.ToString());
                hattyu.EmID = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                hattyu.HaDate = dateTimePickerHaDate.Value;
                hattyu.WaWarehouseFlag = check_nyuko;
                hattyu.HaFlag = check;
                hattyu.HaHidden = textBoxHaHidden.Text;

                //発注詳細テーブルを更新
                var hattyudetail = context.T_HattyuDetails.Single(x => x.HaID == haid);
                hattyudetail.PrID = int.Parse(comboBoxProduct.SelectedValue.ToString());
                hattyudetail.HaQuantity = int.Parse(textBoxHaQuantity.Text);
                context.SaveChanges();

                

                //入庫済みフラグが１の時
                if (hattyu.WaWarehouseFlag == 1)
                {
                    var warehousing = new T_Warehousing
                    {
                        HaID = hattyu.HaID,
                        EmID = hattyu.EmID,
                        WaDate = DateTime.Now,
                        WaShelfFlag = 0,
                        WaFlag = 0,
                        WaHidden = ""
                    };

                    try
                    {
                        context.T_Warehousings.Add(warehousing);
                        context.SaveChanges();   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    var warehousingdetail = new T_WarehousingDetail
                    {
                        WaID = warehousing.WaID,
                        PrID = hattyudetail.PrID,
                        WaQuantity = hattyudetail.HaQuantity
                    };

                    try
                    {
                        context.T_WarehousingDetails.Add(warehousingdetail);
                        context.SaveChanges();
                        context.Dispose();
                        fncAllSelect();
                        MessageBox.Show("入庫を確定しました");
                        InputClear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                

                context.Dispose();
                fncAllSelect();
                if(check == 2)
                {
                    MessageBox.Show("非表示にしました");
                    return;
                }
                MessageBox.Show("更新完了");
                InputClear();
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
            string prid = string.Empty;
            if (!String.IsNullOrEmpty(textBoxHaID.Text.Trim()))
            {
                haid = textBoxHaID.Text;
            }
            if(comboBoxMaker.SelectedIndex != -1)
            {
                maid = comboBoxMaker.SelectedValue.ToString();
            }
            if(comboBoxProduct.SelectedIndex != -1)
            {
                prid = comboBoxProduct.SelectedValue.ToString();
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
                         join t4 in context.T_HattyuDetails
                         on t1.HaID equals t4.HaID
                         join t5 in context.M_Products
                         on t4.PrID equals t5.PrID
                         where t1.HaID.ToString().Contains(haid) &&
                               t2.MaID.ToString().Contains(maid) &&
                               t3.EmID.ToString().Contains(emid) &&
                               t4.PrID.ToString().Contains(prid) 
                         select new
                         {
                             t1.HaID,
                             t2.MaName,
                             t5.PrName,
                             t3.EmName,
                             t1.HaDate,
                             t4.HaQuantity,
                             t1.WaWarehouseFlag,
                             t1.HaFlag,
                             t1.HaHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.HaID, p.MaName, p.PrName, p.EmName, p.HaDate, p.HaQuantity, p.WaWarehouseFlag, p.HaFlag, p.HaHidden);
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
            InputClear();
        }

        private void InputClear()
        {
            textBoxHaID.Text = "";
            comboBoxMaker.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            dateTimePickerHaDate.Value = DateTime.Now;
            textBoxHaQuantity.Text = "";
            textBoxHaHidden.Text = "";
            checkBoxWaWarehouseFlag.Checked = false;
            checkBoxHaFlag.Checked = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(textBoxHaID.Text))
            {
                MessageBox.Show("発注IDを入力してください");
                return;
            }

            int flg;
            if(checkBoxWaWarehouseFlag.Checked == true)
            {
                flg = 1;
            }
            else
            {
                flg = 0;
                MessageBox.Show("発注確定にチェックを入れてください");
                return;
            }

            var context = new SalesManagement_DevContext();
            int haid = int.Parse(textBoxHaID.Text);
            var hattyu = context.T_Hattyus.Single(x => x.HaID == haid);

            try
            {
                //発注確定フラグを１に
                hattyu.WaWarehouseFlag = flg;
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            var hattyudetail = context.T_HattyuDetails.Single(x => x.HaID == haid);

            try
            {
                var warehousing = new T_Warehousing
                {
                    HaID = hattyu.HaID,
                    EmID = hattyu.EmID,
                    WaDate = DateTime.Now,
                    WaShelfFlag = 0,
                    WaFlag = 0,
                    WaHidden = ""
                };
                context.T_Warehousings.Add(warehousing);
                context.SaveChanges();

                var warehousingdetail = new T_WarehousingDetail
                {
                    WaID = warehousing.WaID,
                    PrID = hattyudetail.PrID,
                    WaQuantity = hattyudetail.HaQuantity
                };

                context.T_WarehousingDetails.Add(warehousingdetail);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("発注を確定しました");
                InputClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHaID.Text))
            {
                MessageBox.Show("発注IDを入力してください");
                return;
            }

            int flg;
            if(checkBoxHaFlag.Checked == true)
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
                int haid = int.Parse(textBoxHaID.Text);
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Single(x => x.HaID == haid);
                hattyu.HaFlag = flg;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                InputClear();
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
            buttonConfirm.Visible = true;
            buttonHidden.Visible = true;
            buttonSearch.Visible = false;
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
            buttonRegester.Visible = false;
            buttonConfirm.Visible = false;
            buttonHidden.Visible = false;
            buttonSearch.Visible = true;
            labelRequired1.Visible = false;
            labelRequired2.Visible = false;
            labelRequired3.Visible = false;
            labelRequired4.Visible = false;
            labelRequired5.Visible = false;
            labelRequired6.Visible = false;
            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }

        private void checkBoxWaWarehouseFlag_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxWaWarehouseFlag.Checked == true)
            {
                comboBoxMaker.Enabled = false;
                comboBoxEmployee.Enabled = false;
                comboBoxProduct.Enabled = false;
            }
            else
            {
                comboBoxMaker.Enabled = true;
                comboBoxEmployee.Enabled = true;
                comboBoxProduct.Enabled = true;
            }
        }
    }
}
