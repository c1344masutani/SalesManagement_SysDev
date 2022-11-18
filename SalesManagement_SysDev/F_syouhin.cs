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
        public F_syouhin()
        {
            InitializeComponent();
        }

        private void Regester_button_Click(object sender, EventArgs e)
        {
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
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
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
            textBoxMaID.Text = "";
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

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_product_Load(object sender, EventArgs e)
        {

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
    }
}
