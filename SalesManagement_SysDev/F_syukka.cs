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
    public partial class F_syukka : Form
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

        public F_syukka()
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

        private void F_syukka_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "出荷ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "顧客名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "営業所名";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "出荷完了年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "出荷確定フラグ";
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
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Shipments
                         join t2 in context.M_Clients
                         on t1.ClID equals t2.ClID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_SalesOffices
                         on t1.SoID equals t4.SoID
                         where t1.ShFlag == 0
                         select new
                         {
                             t1.ShID,
                             t2.ClName,
                             t3.EmName,
                             t4.SoName,
                             t1.OrID,
                             t1.ShFinishDate,
                             t1.ShStateFlag,
                             t1.ShFlag,
                             t1.ShHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ShID, p.ClName, p.EmName, p.SoName, p.OrID, p.ShFinishDate, p.ShStateFlag, p.ShFlag, p.ShHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string shid = string.Empty;
            string clid = string.Empty;
            string emid = string.Empty;
            string soid = string.Empty;
            string orid = string.Empty;

            if (!String.IsNullOrEmpty(textBoxShID.Text.Trim()))
            {
                shid = textBoxShID.Text;
            }
            if(comboBoxClient.SelectedIndex != -1)
            {
                clid = comboBoxClient.SelectedValue.ToString();
            }
            if(comboBoxEmployee.SelectedIndex != -1)
            {
                emid = comboBoxEmployee.SelectedValue.ToString();
            }
            if(comboBoxSalesOffice.SelectedIndex != -1)
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
                var tb = from t1 in context.T_Shipments
                         join t2 in context.M_Clients
                         on t1.ClID equals t2.ClID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_SalesOffices
                         on t1.SoID equals t4.SoID
                         where t1.ShID.ToString().Contains(shid) &&
                               t1.ClID.ToString().Contains(clid) &&
                               t1.EmID.ToString().Contains(emid) &&
                               t1.SoID.ToString().Contains(soid) &&
                               t1.OrID.ToString().Contains(orid)
                         select new
                         {
                             t1.ShID,
                             t2.ClName,
                             t3.EmName,
                             t4.SoName,
                             t1.OrID,
                             t1.ShFinishDate,
                             t1.ShStateFlag,
                             t1.ShFlag,
                             t1.ShHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.ShID, p.ClName, p.EmName, p.SoName, p.OrID, p.ShFinishDate, p.ShStateFlag, p.ShFlag, p.ShHidden);
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
            if (!String.IsNullOrEmpty(textBoxShID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxShID.Text.Trim()))
                {
                    MessageBox.Show("出荷IDは数値です");
                    textBoxShID.Focus();
                    return;
                }
                if (textBoxShID.TextLength > 6)
                {
                    MessageBox.Show("出荷IDは6文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("出荷を入力してください");
                return;
            }

            if (!String.IsNullOrEmpty(textBoxShHidden.Text.Trim()))
            {
                if (textBoxShHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            var context = new SalesManagement_DevContext();
            int shid = int.Parse(textBoxShID.Text);
            int flg;
            if (checkBoxShStateFlag.Checked == true)
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
                //出荷テーブルの確定フラグを１に
                var shipment = context.T_Shipments.Single(x => x.ShID == shid);
                shipment.ShStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //  売上テーブルにデータを追加
            try
            {
                var shipment = context.T_Shipments.Single(x => x.ShID == shid);
                var shipmentdetail = context.T_ShipmentDetails.Single(x => x.ShID == shid);
                var order = context.T_Orders.Single(x => x.OrID == shipment.OrID);
                var orderdetail = context.T_OrderDetails.Single(x => x.OrID == order.OrID);
                var product = context.M_Products.Single(x => x.PrID == shipmentdetail.PrID);

                //売上テーブルに追加
                var sale = new T_Sale
                {
                    ClID = shipment.ClID,
                    SoID = shipment.SoID,
                    EmID = shipment.EmID,
                    ChID = shipment.OrID,
                    SaDate = DateTime.Now,
                    SaFlag = 0,
                    SaHidden = ""
                };
                context.T_Sale.Add(sale);
                context.SaveChanges();

                //売上詳細テーブルに追加
                var salementdetail = new T_SaleDetail
                {
                    SaID = sale.SaID,
                    PrID = orderdetail.PrID,
                    SaQuantity = orderdetail.OrQuantity,
                    SaPrTotalPrice = product.Price * orderdetail.OrQuantity
                };
                context.T_ShipmentDetails.Add(shipmentdetail);
                context.SaveChanges();
                ClearInput();
                MessageBox.Show("出荷を確定しました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            context.Dispose();
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxShID.Text))
            {
                MessageBox.Show("出荷IDを入力してください");
                return;
            }

            int flg;
            if (checkBoxShFlag.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int shid = int.Parse(textBoxShID.Text);
                var context = new SalesManagement_DevContext();
                var shipment = context.T_Shipments.Single(x => x.ShID == shid);
                shipment.ShFlag = flg;
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
            textBoxShID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerShFinishDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void ClearInput()
        {
            textBoxShID.Text = "";
            comboBoxClient.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxSalesOffice.SelectedIndex = -1;
            textBoxOrID.Text = "";
            dateTimePickerShFinishDate.Value = DateTime.Today;
            checkBoxShFlag.Checked = false;
            checkBoxShStateFlag.Checked = false;
            textBoxShHidden.Text = "";
        }
    }
}
