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
    public partial class F_tyuumon : Form
    {
        public F_tyuumon()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void Disp_button_Click(object sender, EventArgs e)
        {

        }

        private void F_tyuumon_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 9;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "注文ID";
            dataGridViewDsp.Columns[1].Width = 70;
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "注文年月日";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "注文確定フラグ";
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
                foreach (var p in context.T_Chumons)
                {
                    dataGridViewDsp.Rows.Add(p.ChID,p.SoID,p.EmID,p.ClID,p.OrID,p.ChDate,p.ChStateFlag,p.ChFlag,p.ChHidden);
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

        

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            if (textBoxChid.Text == "" || textBoxChid.Text == null)
            {
                fncAllSelect();
                return;
            }
            int chid = int.Parse(textBoxChid.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var chumon = context.T_Chumons.Where(x => x.ChID == chid).ToArray();
                dataGridViewDsp.Rows.Add(chumon[0].ChID,chumon[0].SoID,chumon[0].EmID,chumon[0].ClID,chumon[0].OrID,chumon[0].ChDate,chumon[0].ChStateFlag,chumon[0].ChFlag,chumon[0].ChHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxChid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxSoid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxEmid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxCliid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxOrid.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            dateTimePickerChdate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString());
            textBoxChHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxChid.Text = "";
            textBoxSoid.Text = "";
            textBoxEmid.Text = "";
            textBoxCliid.Text = "";
            textBoxOrid.Text = "";
            dateTimePickerChdate.Value = DateTime.Today;
            checkBoxChStateflg.Checked = false;
            checkBoxChflg.Checked = false;
            textBoxChHidden.Text = "";
            fncAllSelect();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var context = new SalesManagement_DevContext();
            int chid = int.Parse(textBoxChid.Text);
            int flg;
            if (checkBoxChStateflg.Checked == true)
            {
                flg = 1;
            }
            else
            {
                flg = 0;
            }

            try
            {
                //注文テーブルの確定フラグを１に
                var chumon = context.T_Chumons.Single(x => x.ChID == chid);
                chumon.ChStateFlag = flg;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //在庫数を減らす
            try
            {
                //注文詳細の商品IDを取得
                var chumondetail = context.T_ChumonDetails.Single(x => x.ChID == chid);
                var stock = context.T_Stocks.Single(x => x.PrID == chumondetail.PrID);
                //在庫数から注文数を引く
                stock.StQuantity = stock.StQuantity - chumondetail.ChQuantity;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出庫テーブル・出庫詳細テーブルにデータを追加
            try
            {
                var chumon = context.T_Chumons.Single(x => x.ChID == chid);
                var chumondetail = context.T_ChumonDetails.Single(x => x.ChID == chid);
                //出庫テーブルに追加
                var syukko = new T_Syukko
                {
                    EmID = chumon.EmID,
                    ClID = chumon.ClID,
                    SoID = chumon.SoID,
                    OrID = chumon.OrID,
                    SyDate = chumon.ChDate,
                    SyStateFlag = 0,
                    SyFlag = 0,
                    SyHidden = ""
                };
                context.T_Syukkos.Add(syukko);
                context.SaveChanges();

                var syukkodetail = new T_SyukkoDetail
                {
                    SyID = syukko.SyID,
                    PrID = chumondetail.PrID,
                    SyQuantity = chumondetail.ChQuantity
                };
                context.T_SyukkoDetails.Add(syukkodetail);
                context.SaveChanges();
                MessageBox.Show("注文を確定しました");
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
            if (checkBoxChflg.Checked == true)
            {
                flg = 2;
            }
            else
            {
                flg = 0;
            }

            try
            {
                int chid = int.Parse(textBoxChid.Text);
                var context = new SalesManagement_DevContext();
                var chumon = context.T_Chumons.Single(x => x.ChID == chid);
                chumon.ChFlag = flg;
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
