
namespace SalesManagement_SysDev
{
    partial class F_zaiko
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStID = new System.Windows.Forms.TextBox();
            this.textBoxStQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_StFlag = new System.Windows.Forms.CheckBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonHidden = new System.Windows.Forms.Button();
            this.buttonUpdateMode = new System.Windows.Forms.Button();
            this.buttonSearchMode = new System.Windows.Forms.Button();
            this.labelRequired1 = new System.Windows.Forms.Label();
            this.labelRequired2 = new System.Windows.Forms.Label();
            this.labelRequired3 = new System.Windows.Forms.Label();
            this.labelRequired4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(312, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "在 庫 管 理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(150, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "在庫ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(826, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "在庫数";
            // 
            // textBoxStID
            // 
            this.textBoxStID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxStID.Location = new System.Drawing.Point(425, 175);
            this.textBoxStID.Multiline = true;
            this.textBoxStID.Name = "textBoxStID";
            this.textBoxStID.ReadOnly = true;
            this.textBoxStID.Size = new System.Drawing.Size(206, 51);
            this.textBoxStID.TabIndex = 4;
            // 
            // textBoxStQuantity
            // 
            this.textBoxStQuantity.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxStQuantity.Location = new System.Drawing.Point(1089, 237);
            this.textBoxStQuantity.Multiline = true;
            this.textBoxStQuantity.Name = "textBoxStQuantity";
            this.textBoxStQuantity.Size = new System.Drawing.Size(206, 51);
            this.textBoxStQuantity.TabIndex = 6;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(157, 394);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1700, 550);
            this.dataGridViewDsp.TabIndex = 10;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_Search.Location = new System.Drawing.Point(793, 32);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(300, 56);
            this.button_Search.TabIndex = 11;
            this.button_Search.Text = "検索";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_Update.Location = new System.Drawing.Point(730, 31);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(154, 56);
            this.button_Update.TabIndex = 12;
            this.button_Update.Text = "更新";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_back.Location = new System.Drawing.Point(1703, 26);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(154, 56);
            this.button_back.TabIndex = 13;
            this.button_back.Text = "戻る";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_StFlag
            // 
            this.checkBox_StFlag.AutoSize = true;
            this.checkBox_StFlag.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_StFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBox_StFlag.Location = new System.Drawing.Point(157, 330);
            this.checkBox_StFlag.Name = "checkBox_StFlag";
            this.checkBox_StFlag.Size = new System.Drawing.Size(163, 44);
            this.checkBox_StFlag.TabIndex = 50;
            this.checkBox_StFlag.Text = "非表示";
            this.checkBox_StFlag.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Transparent;
            this.button_Clear.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_Clear.Location = new System.Drawing.Point(1275, 31);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(321, 59);
            this.button_Clear.TabIndex = 69;
            this.button_Clear.Text = "入力クリア";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(151, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 40);
            this.label7.TabIndex = 70;
            this.label7.Text = "商品名";
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPrName.Location = new System.Drawing.Point(425, 251);
            this.textBoxPrName.Multiline = true;
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(206, 51);
            this.textBoxPrName.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(826, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 40);
            this.label5.TabIndex = 72;
            this.label5.Text = "値段";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPrice.Location = new System.Drawing.Point(1089, 161);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(206, 51);
            this.textBoxPrice.TabIndex = 73;
            // 
            // buttonHidden
            // 
            this.buttonHidden.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonHidden.Location = new System.Drawing.Point(980, 31);
            this.buttonHidden.Name = "buttonHidden";
            this.buttonHidden.Size = new System.Drawing.Size(176, 56);
            this.buttonHidden.TabIndex = 74;
            this.buttonHidden.Text = "非表示";
            this.buttonHidden.UseVisualStyleBackColor = true;
            this.buttonHidden.Click += new System.EventHandler(this.buttonHidden_Click);
            // 
            // buttonUpdateMode
            // 
            this.buttonUpdateMode.BackColor = System.Drawing.Color.LightYellow;
            this.buttonUpdateMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpdateMode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonUpdateMode.Location = new System.Drawing.Point(27, 175);
            this.buttonUpdateMode.Name = "buttonUpdateMode";
            this.buttonUpdateMode.Size = new System.Drawing.Size(98, 82);
            this.buttonUpdateMode.TabIndex = 75;
            this.buttonUpdateMode.Text = "更新\r\nモード";
            this.buttonUpdateMode.UseVisualStyleBackColor = false;
            this.buttonUpdateMode.Click += new System.EventHandler(this.buttonUpdateMode_Click);
            // 
            // buttonSearchMode
            // 
            this.buttonSearchMode.BackColor = System.Drawing.Color.Orange;
            this.buttonSearchMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearchMode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearchMode.Location = new System.Drawing.Point(27, 305);
            this.buttonSearchMode.Name = "buttonSearchMode";
            this.buttonSearchMode.Size = new System.Drawing.Size(98, 82);
            this.buttonSearchMode.TabIndex = 76;
            this.buttonSearchMode.Text = "検索\r\nモード";
            this.buttonSearchMode.UseVisualStyleBackColor = false;
            this.buttonSearchMode.Click += new System.EventHandler(this.buttonSearchMode_Click);
            // 
            // labelRequired1
            // 
            this.labelRequired1.AutoSize = true;
            this.labelRequired1.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired1.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired1.ForeColor = System.Drawing.Color.Red;
            this.labelRequired1.Location = new System.Drawing.Point(293, 194);
            this.labelRequired1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired1.Name = "labelRequired1";
            this.labelRequired1.Size = new System.Drawing.Size(44, 18);
            this.labelRequired1.TabIndex = 99;
            this.labelRequired1.Text = "必須";
            // 
            // labelRequired2
            // 
            this.labelRequired2.AutoSize = true;
            this.labelRequired2.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired2.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired2.ForeColor = System.Drawing.Color.Red;
            this.labelRequired2.Location = new System.Drawing.Point(293, 270);
            this.labelRequired2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired2.Name = "labelRequired2";
            this.labelRequired2.Size = new System.Drawing.Size(44, 18);
            this.labelRequired2.TabIndex = 100;
            this.labelRequired2.Text = "必須";
            // 
            // labelRequired3
            // 
            this.labelRequired3.AutoSize = true;
            this.labelRequired3.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired3.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired3.ForeColor = System.Drawing.Color.Red;
            this.labelRequired3.Location = new System.Drawing.Point(928, 194);
            this.labelRequired3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired3.Name = "labelRequired3";
            this.labelRequired3.Size = new System.Drawing.Size(44, 18);
            this.labelRequired3.TabIndex = 101;
            this.labelRequired3.Text = "必須";
            // 
            // labelRequired4
            // 
            this.labelRequired4.AutoSize = true;
            this.labelRequired4.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired4.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired4.ForeColor = System.Drawing.Color.Red;
            this.labelRequired4.Location = new System.Drawing.Point(968, 270);
            this.labelRequired4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired4.Name = "labelRequired4";
            this.labelRequired4.Size = new System.Drawing.Size(44, 18);
            this.labelRequired4.TabIndex = 102;
            this.labelRequired4.Text = "必須";
            // 
            // F_zaiko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.labelRequired4);
            this.Controls.Add(this.labelRequired3);
            this.Controls.Add(this.labelRequired2);
            this.Controls.Add(this.labelRequired1);
            this.Controls.Add(this.buttonSearchMode);
            this.Controls.Add(this.buttonUpdateMode);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.checkBox_StFlag);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.textBoxStQuantity);
            this.Controls.Add(this.textBoxStID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_zaiko";
            this.Text = "stock";
            this.Load += new System.EventHandler(this.F_zaiko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStID;
        private System.Windows.Forms.TextBox textBoxStQuantity;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_StFlag;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonHidden;
        private System.Windows.Forms.Button buttonUpdateMode;
        private System.Windows.Forms.Button buttonSearchMode;
        private System.Windows.Forms.Label labelRequired1;
        private System.Windows.Forms.Label labelRequired2;
        private System.Windows.Forms.Label labelRequired3;
        private System.Windows.Forms.Label labelRequired4;
    }
}