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
    public partial class F_jutyuu : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //コンボボックス用
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();

        //コンボボックス用のデータ
        private static List<M_SalesOffice> SalesOffice;
        private static List<M_Employee> Employee;
        private static List<M_Client> Client;
        private static List<M_Product> Product;


        public F_jutyuu()
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

            //商品コンボボックス
            Product = productDataAccess.GetProductDspData();
            comboBoxProduct.DataSource = Product;
            comboBoxProduct.DisplayMember = "PrName";
            comboBoxProduct.ValueMember = "PrID";
            //読み取り専用
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.SelectedIndex = -1;
        }


        private void F_order_received_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 11;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "受注ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "営業所名";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "社員名";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "顧客名";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "商品名";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "顧客担当者名";
            dataGridViewDsp.Columns[6].Width = 130;
            dataGridViewDsp.Columns[6].HeaderText = "受注年月日";
            dataGridViewDsp.Columns[7].Width = 70;
            dataGridViewDsp.Columns[7].HeaderText = "数量";
            dataGridViewDsp.Columns[8].Width = 70;
            dataGridViewDsp.Columns[8].HeaderText = "受注確定フラグ";
            dataGridViewDsp.Columns[9].Width = 70;
            dataGridViewDsp.Columns[9].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[10].Width = 200;
            dataGridViewDsp.Columns[10].HeaderText = "非表示理由";
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
            labelRequired7.Visible = true;
            labelRequired8.Visible = true;
            buttonUpdateMode.BackColor = Color.Orange;
            buttonSearchMode.BackColor = Color.LightYellow;
        }


        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Orders
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         join t5 in context.T_OrderDetails
                         on t1.OrID equals t5.OrID
                         join t6 in context.M_Products
                         on t5.PrID equals t6.PrID
                         where t1.OrFlag == 0
                         select new
                         {
                             t1.OrID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t6.PrName,
                             t1.ClCharge,
                             t1.OrDate,
                             t5.OrQuantity,
                             t1.OrStateFlag,
                             t1.OrFlag,
                             t1.OrHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.OrID,p.SoName,p.EmName,p.ClName,p.PrName,p.ClCharge,p.OrDate,p.OrQuantity, p.OrStateFlag,p.OrFlag,p.OrHidden);
                }

                context.Dispose();         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
            frm.Dispose();
            this.Close();
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {

            if(comboBoxSalesOffice.SelectedIndex == -1)
            {
                MessageBox.Show("営業所を選択してください");
                return;
            }

            if(comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("社員名を選択してください");
                return;
            }

            if(comboBoxClient.SelectedIndex == -1)
            {
                MessageBox.Show("顧客名を選択してください");
                return;
            }

            if(comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("商品名を選択してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxClCharge.Text.Trim()))
            {

                if (textBoxClCharge.TextLength > 50)
                {
                    MessageBox.Show("顧客担当者名は50文字以下です");
                    textBoxClCharge.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("顧客担当者名を入力してください");
            }

            if (String.IsNullOrEmpty(textBoxOrQuantity.Text))
            {
                MessageBox.Show("数量を入力してください");
                return;
            }
            else
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrQuantity.Text))
                {
                    MessageBox.Show("数量は数字で入力してください");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
            {
                if (textBoxOrHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    textBoxOrHidden.Focus();
                    return;
                }
            }

            int checkOr;
            if (checkBoxOrFlag.Checked == true)
            {
                checkOr = 2;
            }
            else
            {
                checkOr = 0;
            }

            int checkOrState;
            if(checkBoxOrStateFlag.Checked == true)
            {
                checkOrState = 1;
            }
            else
            {
                checkOrState = 0;
            }

            var context = new SalesManagement_DevContext();

            //受注テーブルにデータをセット
            var order = new T_Order
            {

                SoID = int.Parse(comboBoxSalesOffice.SelectedValue.ToString()),
                EmID = int.Parse(comboBoxEmployee.SelectedValue.ToString()),
                ClID = int.Parse(comboBoxClient.SelectedValue.ToString()),
                ClCharge = textBoxClCharge.Text.Trim(),
                OrDate = datetimepickerOrDate.Value,
                OrFlag = checkOr,
                OrStateFlag = checkOrState,
                OrHidden = textBoxOrHidden.Text.Trim()
            };

            //受注テーブルに登録
            try
            {
                context.T_Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //商品テーブルから商品情報取得
            int prid = int.Parse(comboBoxProduct.SelectedValue.ToString());
            
            var product = context.M_Products.Single(x => x.PrID == prid);
            
            //受注詳細テーブルにデータをセット
            var orderdetail = new T_OrderDetail
            {
                OrID = order.OrID,
                PrID = product.PrID,
                OrQuantity = int.Parse(textBoxOrQuantity.Text),
                OrTotalPrice = product.Price * int.Parse(textBoxOrQuantity.Text)
            };

            //受注詳細テーブルに登録
            try
            {
                context.T_OrderDetails.Add(orderdetail);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                InputClear();
                MessageBox.Show("登録完了");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxOrID.Text))
            {
                MessageBox.Show("受注IDを入力してください");
                return;
            }

            if (comboBoxSalesOffice.SelectedIndex == -1)
            {
                MessageBox.Show("営業所を選択してください");
                return;
            }

            if (comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("社員名を選択してください");
                return;
            }

            if (comboBoxClient.SelectedIndex == -1)
            {
                MessageBox.Show("顧客名を選択してください");
                return;
            }

            if (comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("商品名を選択してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxClCharge.Text.Trim()))
            {

                if (textBoxClCharge.TextLength > 50)
                {
                    MessageBox.Show("顧客担当者名は50文字以下です");
                    textBoxClCharge.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("顧客担当者名を入力してください");
            }

            if (String.IsNullOrEmpty(textBoxOrQuantity.Text))
            {
                MessageBox.Show("数量を入力してください");
                return;
            }
            else
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrQuantity.Text))
                {
                    MessageBox.Show("数量は数字で入力してください");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
            {
                if (textBoxOrHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    textBoxOrHidden.Focus();
                    return;
                }
            }

            int checkOr;
            if (checkBoxOrFlag.Checked == true)
            {
                checkOr = 2;
            }
            else
            {
                checkOr = 0;
            }

            int checkOrState;
            if (checkBoxOrStateFlag.Checked == true)
            {
                checkOrState = 1;
            }
            else
            {
                checkOrState = 0;
            }

            var context = new SalesManagement_DevContext();
            int orid = int.Parse(textBoxOrID.Text.Trim());
            try
            {
                
                //受注テーブル
                var order = context.T_Orders.Single(x => x.OrID == orid);
                order.SoID = int.Parse(comboBoxSalesOffice.SelectedValue.ToString());
                order.EmID = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                order.ClID = int.Parse(comboBoxClient.SelectedValue.ToString());
                order.ClCharge = textBoxClCharge.Text.Trim();
                order.OrDate = datetimepickerOrDate.Value;
                order.OrStateFlag = checkOrState;
                order.OrFlag = checkOr;
                order.OrHidden = textBoxOrHidden.Text;

                //受注詳細テーブル
                var orderdetail = context.T_OrderDetails.Single(x => x.OrID == orid);
                //商品テーブルから商品情報取得
                int prid = int.Parse(comboBoxProduct.SelectedValue.ToString());
                var product = context.M_Products.Single(x => x.PrID == prid);
                orderdetail.PrID = prid;
                orderdetail.OrQuantity = int.Parse(textBoxOrQuantity.Text);
                orderdetail.OrTotalPrice = product.Price * int.Parse(textBoxOrQuantity.Text);
                context.SaveChanges();


                //受注確定フラグが1の時
                if (order.OrStateFlag == 1)
                {
                    var chuumon = new T_Chumon
                    {
                        SoID = order.SoID,
                        EmID = order.EmID,
                        ClID = order.ClID,
                        OrID = order.OrID,
                        ChDate = DateTime.Now,
                        ChStateFlag = 0,
                        ChFlag = 0,
                        ChHidden = ""
                    };

                    context.T_Chumons.Add(chuumon);
                    context.SaveChanges();

                    var chuumondetail = new T_ChumonDetail
                    {
                        ChID = chuumon.ChID,
                        PrID = orderdetail.PrID,
                        ChQuantity = orderdetail.OrQuantity
                    };

                    context.T_ChumonDetails.Add(chuumondetail);
                    context.SaveChanges();
                    context.Dispose();
                    fncAllSelect();
                    InputClear();
                    MessageBox.Show("受注を確定しました");
                    return;
                }
                
                
                

                context.Dispose();
                fncAllSelect();
                InputClear();

                //非表示メッセージ
                if (checkOr == 2)
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            comboBoxProduct.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            textBoxClCharge.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            datetimepickerOrDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString());
            textBoxOrQuantity.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            textBoxOrHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[10].Value.ToString();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string orid = string.Empty;
            string soid = string.Empty;
            string emid = string.Empty;
            string clid = string.Empty;
            string clcharge = string.Empty;

            if (!String.IsNullOrEmpty(textBoxOrID.Text))
            {
                orid = textBoxOrID.Text;
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
            if (!String.IsNullOrEmpty(textBoxClCharge.Text))
            {
                clcharge = textBoxClCharge.Text;
            }

            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Orders
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         join t5 in context.T_OrderDetails
                         on t1.OrID equals t5.OrID
                         join t6 in context.M_Products
                         on t5.PrID equals t6.PrID
                         where t1.OrID.ToString().Contains(orid) &&
                               t1.SoID.ToString().Contains(soid) &&
                               t1.EmID.ToString().Contains(emid) &&
                               t1.ClID.ToString().Contains(clid) &&
                               t1.ClCharge.Contains(clcharge) &&
                               t1.OrFlag == 0
                         select new
                         {
                             t1.OrID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t6.PrName,
                             t1.ClCharge,
                             t1.OrDate,
                             t5.OrQuantity,
                             t1.OrStateFlag,
                             t1.OrFlag,
                             t1.OrHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.OrID, p.SoName, p.EmName, p.ClName, p.PrName, p.ClCharge, p.OrDate,p.OrQuantity, p.OrStateFlag, p.OrFlag, p.OrHidden);
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
            fncAllSelect();

        }

        private void InputClear()
        {
            textBoxOrID.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxClient.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            textBoxClCharge.Text = "";
            textBoxOrQuantity.Text = "";
            checkBoxOrFlag.Checked = false;
            checkBoxOrStateFlag.Checked = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxOrID.Text))
            {
                MessageBox.Show("受注IDを入力してください");
                return;
            }

            int flg = 0;
            if (checkBoxOrStateFlag.Checked == true)
            {
                DialogResult result = MessageBox.Show("受注を確定してもよろしいですか", "受注確定確認", MessageBoxButtons.OKCancel);
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
                MessageBox.Show("受注確定にチェックを入れてください");
                return;
            }

            var context = new SalesManagement_DevContext();
            int orid = int.Parse(textBoxOrID.Text);

            try
            {
                //受注確定フラグを1に
                var order = context.T_Orders.Single(x => x.OrID == orid);
                order.OrStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var order = context.T_Orders.Single(x => x.OrID == orid);
                var orderdetail = context.T_OrderDetails.Single(x => x.OrID == orid);

                var chuumon = new T_Chumon
                {
                    SoID = order.SoID,
                    EmID = order.EmID,
                    ClID = order.ClID,
                    OrID = order.OrID,
                    ChDate = DateTime.Now,
                    ChStateFlag = 0,
                    ChFlag = 0,
                    ChHidden = ""
                };

                context.T_Chumons.Add(chuumon);
                context.SaveChanges();

                var chuumondetail = new T_ChumonDetail
                {
                    ChID = chuumon.ChID,
                    PrID = orderdetail.PrID,
                    ChQuantity = orderdetail.OrQuantity
                };

                context.T_ChumonDetails.Add(chuumondetail);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                InputClear();
                MessageBox.Show("受注を確定しました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxOrID.Text))
            {
                MessageBox.Show("受注IDを入力してください");
                return;
            }

            int flg = 0;
            if(checkBoxOrFlag.Checked == true)
            {
                DialogResult result = MessageBox.Show("非表示してもよろしいですか？", "非表示確認", MessageBoxButtons.OKCancel);
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
                int orid = int.Parse(textBoxOrID.Text);
                var context = new SalesManagement_DevContext();
                var order = context.T_Orders.Single(x => x.OrID == orid);
                order.OrFlag = flg;
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
            labelRequired7.Visible = true;
            labelRequired8.Visible = true;
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
            labelRequired7.Visible = false;
            labelRequired8.Visible = false;
            buttonUpdateMode.BackColor = Color.LightYellow;
            buttonSearchMode.BackColor = Color.Orange;
        }

        private void checkBoxOrStateFlag_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxOrStateFlag.Checked == true)
            {
                comboBoxClient.Enabled = false;
                comboBoxEmployee.Enabled = false;
                comboBoxProduct.Enabled = false;
                comboBoxSalesOffice.Enabled = false;
                textBoxClCharge.Enabled = false;
                textBoxOrQuantity.Enabled = false;
            }
            else
            {
                comboBoxClient.Enabled = true;
                comboBoxEmployee.Enabled = true;
                comboBoxProduct.Enabled = true;
                comboBoxSalesOffice.Enabled = true;
                textBoxClCharge.Enabled = true;
                textBoxOrQuantity.Enabled = true;
            }
        }

        private void F_jutyuu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}