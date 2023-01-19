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

        public F_syukko()
        {
            InitializeComponent();
        }


        

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
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
                         where t1.SyFlag == 0
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
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SyID, p.EmName, p.ClName, p.SoName, p.OrID, p.SyDate, p.SyStateFlag, p.SyFlag, p.SyHidden);
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
            if (String.IsNullOrEmpty(textBoxSyID.Text))
            {
                MessageBox.Show("出庫IDを入力してください");
                return;

            }

            var context = new SalesManagement_DevContext();
            int syid = int.Parse(textBoxSyID.Text);
            int flg = 0;
            if (checkBoxSyStateFlag.Checked == true)
            {
                DialogResult result = MessageBox.Show("出庫を確定してもよろしいですか？", "出庫確定確認", MessageBoxButtons.OKCancel);
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
                flg = 0;
                MessageBox.Show("出庫確定にチェックを入れてください");
                return;
            }

            try
            {
                //出庫テーブルの確定フラグを１に 確定日を登録
                var syukko = context.T_Syukkos.Single(x => x.SyID == syid);
                syukko.SyDate = DateTime.Now;
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
                    ArDate = null,
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
                ClearInput();
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
            if (String.IsNullOrEmpty(textBoxSyID.Text))
            {
                MessageBox.Show("出庫IDを入力してください");
                return;
            }
            int flg = 0;
            if (checkBoxSyFlg.Checked == true)
            {
                DialogResult result = MessageBox.Show("非表示にしてもよろしいですか？", "非表示確認", MessageBoxButtons.OKCancel);
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
                int syid = int.Parse(textBoxSyID.Text);
                var context = new SalesManagement_DevContext();
                var syukko = context.T_Syukkos.Single(x => x.SyID == syid);
                syukko.SyFlag = flg;
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
            textBoxSyID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxEmployee.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxClient.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxSalesOffice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            //dateTimePickerSyDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString() == "1")
            {
                checkBoxSyStateFlag.Checked = true;
            }
            else
            {
                checkBoxSyStateFlag.Checked = false;
            }

            if(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString() == "2")
            {
                checkBoxSyFlg.Checked = true;
            }
            else
            {
                checkBoxSyFlg.Checked = false;
            }
            textBoxSyHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();

        }

        private void PriceTextBox_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            textBoxSyID.Text = "";
            textBoxEmployee.Text = "";
            textBoxClient.Text = "";
            textBoxSalesOffice.Text = "";
            textBoxOrID.Text = "";
            dateTimePickerSyDate.Value = DateTime.Now;
            checkBoxSyStateFlag.Checked = false;
            checkBoxSyFlg.Checked = false;
            textBoxSyHidden.Text = "";
        }

        private void checkBoxSyStateFlag_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void F_syukko_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
