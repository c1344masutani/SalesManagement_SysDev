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
    public partial class F_syouhin : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        //データベース商品メーカテーブルアクセス用クラスのインスタンス化
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        SmallClassificationDataAccess SmallClassificationDataAccess = new SmallClassificationDataAccess();

        //コンボボックス用の商品メーカデータ
        private static List<M_Maker> Maker;
        private static List<M_SmallClassification> SmallClassifications;
        

        public F_syouhin()
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

            //小分類コンボボックス
            SmallClassifications = SmallClassificationDataAccess.GetSmallClassificationDspData();
            comboBoxSmallClass.DataSource = SmallClassifications;
            comboBoxSmallClass.DisplayMember = "ScName";
            comboBoxSmallClass.ValueMember = "ScID";
            //小分類コンボボックスを読み取り専用
            comboBoxSmallClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSmallClass.SelectedIndex = -1;

            //色コンボボックス
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColor.SelectedIndex = -1;
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                if (textBoxPrName.TextLength > 50)
                {
                    MessageBox.Show("商品名は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("商品名を入力してください");
                return;
            }

            if(comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカ名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxPrice.Text.Trim()))
                {
                    MessageBox.Show("価格は数値です");
                    textBoxPrice.Focus();
                    return;
                }
                if (textBoxPrice.TextLength > 9)
                {
                    MessageBox.Show("価格は9文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("価格を入力してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxPrSafetyStock.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxPrSafetyStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は数値です");
                    textBoxPrSafetyStock.Focus();
                    return;
                }
                if (textBoxPrSafetyStock.TextLength > 4)
                {
                    MessageBox.Show("安全在庫数は4文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数を入力してください");
                return;
            }

            if(comboBoxSmallClass.SelectedIndex == -1)
            {
                MessageBox.Show("小分類名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                if (textBoxPrModelNumber.TextLength > 20)
                {
                    MessageBox.Show("型番は20文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("型番を入力してください");
                return;
            }

            if(comboBoxColor.SelectedIndex == -1)
            {
                MessageBox.Show("色を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxHidden.Text.Trim()))
            {
                if (textBoxHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            int check;
            if (checkBoxPrFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            var product = new M_Product
            {
                MaID = int.Parse(comboBoxMaker.SelectedValue.ToString()),
                PrName = textBoxPrName.Text.Trim(),
                Price = int.Parse(textBoxPrice.Text.Trim()),
                PrSafetyStock = int.Parse(textBoxPrSafetyStock.Text.Trim()),
                ScID = int.Parse(comboBoxSmallClass.SelectedValue.ToString()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = comboBoxColor.SelectedItem.ToString(),
                PrReleaseDate = PrReleaseDate.Value,
                PrFlag = check,
                PrHidden = textBoxHidden.Text.Trim()
            };

            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Products.Add(product);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();


        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                if (textBoxPrName.TextLength > 50)
                {
                    MessageBox.Show("商品名は50文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("商品名を入力してください");
                return;
            }

            if (comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカ名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxPrice.Text.Trim()))
                {
                    MessageBox.Show("価格は数値です");
                    textBoxPrice.Focus();
                    return;
                }
                if (textBoxPrice.TextLength > 9)
                {
                    MessageBox.Show("価格は9文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("価格を入力してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxPrSafetyStock.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxPrSafetyStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は数値です");
                    textBoxPrSafetyStock.Focus();
                    return;
                }
                if (textBoxPrSafetyStock.TextLength > 4)
                {
                    MessageBox.Show("安全在庫数は4文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数を入力してください");
                return;
            }

            if (comboBoxSmallClass.SelectedIndex == -1)
            {
                MessageBox.Show("小分類名を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                if (textBoxPrModelNumber.TextLength > 20)
                {
                    MessageBox.Show("型番は20文字以下です");
                    return;
                }
            }
            else
            {
                MessageBox.Show("型番を入力してください");
                return;
            }

            if (comboBoxColor.SelectedIndex == -1)
            {
                MessageBox.Show("色を選択してください");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxHidden.Text.Trim()))
            {
                if (textBoxHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }

            int check;
            if (checkBoxPrFlag.Checked == true)
            {
                check = 2;
            }
            else
            {
                check = 0;
            }

            try
            {
                int prid = int.Parse(textBoxPrID.Text);
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Single(x => x.PrID == prid);
                product.MaID = int.Parse(comboBoxMaker.SelectedValue.ToString());
                product.PrName = textBoxPrName.Text.Trim();
                product.Price = int.Parse(textBoxPrice.Text.Trim());
                product.PrSafetyStock = int.Parse(textBoxPrSafetyStock.Text.Trim());
                product.ScID = int.Parse(comboBoxSmallClass.SelectedValue.ToString());
                product.PrModelNumber = textBoxPrModelNumber.Text.Trim();
                product.PrColor = comboBoxColor.SelectedItem.ToString();
                product.PrReleaseDate = PrReleaseDate.Value;
                product.PrFlag = check;
                product.PrHidden = textBoxHidden.Text.Trim();
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

        private void dataGridViewDsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void F_product_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 11;
            //0番目（左端）の列幅を設定
            dataGridViewDsp.Columns[0].Width = 70;
            //0番目（左端）の項目名を設定
            dataGridViewDsp.Columns[0].HeaderText = "商品ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "商品名";
            dataGridViewDsp.Columns[2].Width = 70;
            dataGridViewDsp.Columns[2].HeaderText = "メーカID";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "価格";
            dataGridViewDsp.Columns[4].Width = 70;
            dataGridViewDsp.Columns[4].HeaderText = "安全在庫数";
            dataGridViewDsp.Columns[5].Width = 70;
            dataGridViewDsp.Columns[5].HeaderText = "小分類名";
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[6].HeaderText = "型番";
            dataGridViewDsp.Columns[7].Width = 70;
            dataGridViewDsp.Columns[7].HeaderText = "色";
            dataGridViewDsp.Columns[8].Width = 130;
            dataGridViewDsp.Columns[8].HeaderText = "発売日";
            dataGridViewDsp.Columns[9].Width = 70;
            dataGridViewDsp.Columns[9].HeaderText = "非表示フラグ";
            dataGridViewDsp.Columns[10].Width = 130;
            dataGridViewDsp.Columns[10].HeaderText = "非表示理由";
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
                var tb = from t1 in context.M_Products
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         join t3 in context.M_SmallClassifications
                         on t1.ScID equals t3.ScID
                         where t1.PrFlag == 0
                         select new
                         {
                             t1.PrID,
                             t1.PrName,
                             t2.MaName,
                             t1.Price,
                             t1.PrSafetyStock,
                             t3.ScName,
                             t1.PrModelNumber,
                             t1.PrColor,
                             t1.PrReleaseDate,
                             t1.PrFlag,
                             t1.PrHidden
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.PrID, p.PrName, p.MaName, p.Price, p.PrSafetyStock, p.ScName, p.PrModelNumber, p.PrColor, p.PrReleaseDate, p.PrFlag, p.PrHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrColorTextBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu2();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void PrIDTextBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxPrName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxMaker.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxPrSafetyStock.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            comboBoxSmallClass.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            textBoxPrModelNumber.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            comboBoxColor.SelectedItem = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            PrReleaseDate.Value = DateTime.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString());
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value.ToString() == "0")
            {
                checkBoxPrFlag.Checked = false;
            }
            else if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value.ToString() == "2")
            {
                checkBoxPrFlag.Checked = true;
            }
            textBoxHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[10].Value.ToString();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            
            dataGridViewDsp.Rows.Clear();
            string prid = string.Empty;
            string prname = string.Empty;
            string maid = string.Empty;
            string price = string.Empty;
            string stock = string.Empty;
            string smallclass = string.Empty;
            string modelnumber = string.Empty;
            string color = string.Empty;
            if (!String.IsNullOrEmpty(textBoxPrID.Text.Trim()))
            {
                prid = textBoxPrID.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                prname = textBoxPrName.Text;
            }
            if(comboBoxMaker.SelectedIndex != -1)
            {
                maid = comboBoxMaker.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                price = textBoxPrice.Text;
            }
            if (!String.IsNullOrEmpty(textBoxPrSafetyStock.Text.Trim()))
            {
                stock = textBoxPrSafetyStock.Text;
            }
            if(comboBoxSmallClass.SelectedIndex != -1)
            {
                smallclass = comboBoxSmallClass.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                modelnumber = textBoxPrModelNumber.Text;
            }
            if(comboBoxColor.SelectedIndex != -1)
            {
                color = comboBoxColor.SelectedItem.ToString();
            }

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Products
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         join t3 in context.M_SmallClassifications
                         on t1.ScID equals t3.ScID
                         where t1.PrID.ToString().Contains(prid) &&
                               t1.PrName.Contains(prname) &&
                               t1.MaID.ToString().Contains(maid) &&
                               t1.Price.ToString().Contains(price) &&
                               t1.PrSafetyStock.ToString().Contains(stock) &&
                               t1.ScID.ToString().Contains(smallclass) &&
                               t1.PrModelNumber.ToString().Contains(modelnumber) &&
                               t1.PrColor.ToString().Contains(color) 
                         select new
                         {
                             t1.PrID,
                             t1.PrName,
                             t2.MaName,
                             t1.Price,
                             t1.PrSafetyStock,
                             t3.ScName,
                             t1.PrModelNumber,
                             t1.PrColor,
                             t1.PrReleaseDate,
                             t1.PrFlag,
                             t1.PrHidden
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.PrID, p.PrName, p.MaName, p.Price, p.PrSafetyStock, p.ScName, p.PrModelNumber, p.PrColor, p.PrReleaseDate, p.PrFlag, p.PrHidden);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new F_Maker();

            Opacity = 0;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void ClearInput()
        {
            textBoxPrID.Text = "";
            comboBoxMaker.SelectedIndex = -1;
            textBoxPrName.Text = "";
            textBoxPrice.Text = "";
            textBoxPrSafetyStock.Text = "";
            comboBoxSmallClass.SelectedIndex = -1;
            textBoxPrModelNumber.Text = "";
            comboBoxColor.SelectedIndex = -1;
            PrReleaseDate.Value = System.DateTime.Now;
            checkBoxPrFlag.Checked = false;
            textBoxHidden.Text = "";
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxPrID.Text))
            {
                MessageBox.Show("商品IDを入力してください");
                return;
            }

            int flg;
            if(checkBoxPrFlag.Checked == true)
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
                int prid = int.Parse(textBoxPrID.Text);
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Single(x => x.PrID == prid);
                product.PrFlag = flg;
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
    }
}
