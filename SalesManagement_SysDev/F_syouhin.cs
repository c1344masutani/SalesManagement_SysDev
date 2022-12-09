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
        ProductDataAccess productDataAccess = new ProductDataAccess();

        //コンボボックス用の商品メーカデータ
        private static List<M_Maker> Maker;
        //データグリッドビュー用の商品データ
        private static List<M_Product> Product;

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
            if (!string.IsNullOrEmpty(textBoxScID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxScID.Text.Trim()))
                {
                    MessageBox.Show("小分類IDは数値です");
                    textBoxScID.Focus();
                    return;
                }
                if (textBoxScID.TextLength > 2)
                {
                    MessageBox.Show("小分類IDは2文字以下です");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                if (textBoxPrModelNumber.TextLength > 20)
                {
                    MessageBox.Show("型番は20文字以下です");
                    return;
                }
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
                ScID = int.Parse(textBoxScID.Text.Trim()),
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
                MessageBox.Show("登録完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPrID.Text = "";
            comboBoxMaker.SelectedIndex = -1;
            textBoxPrName.Text = "";
            textBoxPrice.Text = "";
            textBoxPrSafetyStock.Text = "";
            textBoxScID.Text = "";
            textBoxPrModelNumber.Text = "";
            comboBoxColor.SelectedIndex = -1;
            PrReleaseDate.Value = System.DateTime.Now;
            checkBoxPrFlag.Checked = false;
            textBoxHidden.Text = "";


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
            if (!string.IsNullOrEmpty(textBoxScID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxScID.Text.Trim()))
                {
                    MessageBox.Show("小分類IDは数値です");
                    textBoxScID.Focus();
                    return;
                }
                if (textBoxScID.TextLength > 2)
                {
                    MessageBox.Show("小分類IDは2文字以下です");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                if (textBoxPrModelNumber.TextLength > 20)
                {
                    MessageBox.Show("型番は20文字以下です");
                    return;
                }
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
                product.ScID = int.Parse(textBoxScID.Text.Trim());
                product.PrModelNumber = textBoxPrModelNumber.Text.Trim();
                product.PrColor = comboBoxColor.SelectedItem.ToString();
                product.PrReleaseDate = PrReleaseDate.Value;
                product.PrFlag = check;
                product.PrHidden = textBoxHidden.Text.Trim();
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
                int prid = int.Parse(textBoxPrID.Text);
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Single(x => x.PrID == prid);
                context.M_Products.Remove(product);
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
            dataGridViewDsp.Columns[5].HeaderText = "小分類ID";
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
                foreach (var p in context.M_Products)
                {
                    dataGridViewDsp.Rows.Add(p.PrID,p.PrName,p.MaID,p.Price,p.PrSafetyStock,p.ScID,p.PrModelNumber,p.PrColor,p.PrReleaseDate,p.PrFlag,p.PrHidden);
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
            Form frm = new F_menu();

            Opacity = 0;

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
            textBoxScID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
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
            if (!string.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                if (textBoxPrName.TextLength > 50)
                {
                    MessageBox.Show("商品名は50文字以下です");
                    return;
                }
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
            if (!string.IsNullOrEmpty(textBoxScID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxScID.Text.Trim()))
                {
                    MessageBox.Show("小分類IDは数値です");
                    textBoxScID.Focus();
                    return;
                }
                if (textBoxScID.TextLength > 2)
                {
                    MessageBox.Show("小分類IDは2文字以下です");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                if (textBoxPrModelNumber.TextLength > 20)
                {
                    MessageBox.Show("型番は20文字以下です");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(textBoxHidden.Text.Trim()))
            {
                if (textBoxHidden.TextLength > 200)
                {
                    MessageBox.Show("非表示理由は200文字以下です");
                    return;
                }
            }
            dataGridViewDsp.Rows.Clear();
            if (String.IsNullOrEmpty(textBoxPrID.Text))
            {
                fncAllSelect();
                return;
            }
            int prid = int.Parse(textBoxPrID.Text);
            try
            {
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Where(x => x.PrID == prid).ToArray();
                dataGridViewDsp.Rows.Add(product[0].PrID, product[0].PrName, product[0].MaID, product[0].Price, product[0].PrSafetyStock, product[0].ScID, product[0].PrModelNumber, product[0].PrColor, product[0].PrReleaseDate, product[0].PrFlag, product[0].PrHidden);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
