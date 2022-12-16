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
            dataGridViewDsp.ColumnCount = 10;
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
            dataGridViewDsp.Columns[7].HeaderText = "受注確定フラグ";
            dataGridViewDsp.Columns[8].Width = 70;
            dataGridViewDsp.Columns[8].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[9].Width = 200;
            dataGridViewDsp.Columns[9].HeaderText = "非表示理由";
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
                         select new
                         {
                             t1.OrID,
                             t2.SoName,
                             t3.EmName,
                             t4.ClName,
                             t6.PrName,
                             t1.ClCharge,
                             t1.OrDate,
                             t1.OrStateFlag,
                             t1.OrFlag,
                             t1.OrHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.OrID,p.SoName,p.EmName,p.ClName,p.PrName,p.ClCharge,p.OrDate,p.OrStateFlag,p.OrFlag,p.OrHidden);
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
                DataGridViewRow row = dataGridViewDsp.Rows.Cast<DataGridViewRow>().First(r => r.Cells[8].Value.ToString() == "2");
                row.Visible = false;
            }
            catch (Exception ex)
            {
                // 該当データなし時は、例外が発生する
                //MessageBox.Show(ex.Message);
            }

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

            if (!String.IsNullOrEmpty(textBoxClCharge.Text.Trim()))
            {

                if (textBoxClCharge.TextLength > 50)
                {
                    MessageBox.Show("顧客担当者名は50文字以下です");
                    textBoxClCharge.Focus();
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
                OrQuantity = int.Parse(numericUpDownOrQuantity.Value.ToString()),
                OrTotalPrice = product.Price * int.Parse(numericUpDownOrQuantity.Value.ToString())
            };

            //受注詳細テーブルに登録
            try
            {
                context.T_OrderDetails.Add(orderdetail);
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

        private void Update_button_Click(object sender, EventArgs e)
        {

            

            if (!String.IsNullOrEmpty(textBoxClCharge.Text.Trim()))
            {
                if (textBoxClCharge.TextLength > 50)
                {
                    MessageBox.Show("顧客担当者名は50文字以下です");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
            {
                if (textBoxOrHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
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
                orderdetail.OrQuantity = int.Parse(numericUpDownOrQuantity.Value.ToString());
                orderdetail.OrTotalPrice = product.Price * int.Parse(numericUpDownOrQuantity.Value.ToString());

                context.SaveChanges();

                //注文テーブル 注文状態フラグが1の時
                if (order.OrStateFlag == 1)
                {
                    var chuumon = new T_Chumon
                    {
                        SoID = order.SoID,
                        EmID = order.EmID,
                        ClID = order.ClID,
                        OrID = order.OrID,
                        ChDate = DateTime.Today,
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            comboBoxProduct.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            textBoxClCharge.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            datetimepickerOrDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString());
            textBoxOrHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value.ToString();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {


            

            if (!String.IsNullOrEmpty(textBoxClCharge.Text.Trim()))
            {

                if (!dataInputFormCheck.CheckNumeric(textBoxClCharge.Text.Trim()))
                {
                    MessageBox.Show("M5027");
                    textBoxClCharge.Focus();
                    return;
                }

                if (textBoxClCharge.TextLength > 50)
                {
                    MessageBox.Show("顧客担当者名は50文字以下です");
                    textBoxClCharge.Focus();
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

            dataGridViewDsp.Rows.Clear();
            if(textBoxOrID.Text == "" || textBoxOrID.Text == null)
            {
                fncAllSelect();
                return;
            }
            int orid = int.Parse(textBoxOrID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var order = context.T_Orders.Where(x => x.OrID == orid).ToArray();
                dataGridViewDsp.Rows.Add(order[0].OrID, order[0].SoID, order[0].EmID, order[0].ClID, order[0].ClCharge, order[0].OrDate, order[0].OrStateFlag, order[0].OrFlag, order[0].OrHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOrID.Text = "";
            comboBoxSalesOffice.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxClient.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            textBoxClCharge.Text = "";
            numericUpDownOrQuantity.Value = 0;

        }
    }
}