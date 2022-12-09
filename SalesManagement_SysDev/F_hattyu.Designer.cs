
namespace SalesManagement_SysDev
{
    partial class F_hattyu
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
            this.PriceTextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHaID = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.checkBoxWaWarehouseFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxHaFlag = new System.Windows.Forms.CheckBox();
            this.textBoxHaHidden = new System.Windows.Forms.TextBox();
            this.dateTimePickerHaDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_touroku = new System.Windows.Forms.Button();
            this.button_koushin = new System.Windows.Forms.Button();
            this.button_kensaku = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxMaker = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 56);
            this.label1.TabIndex = 78;
            this.label1.Text = "発 注 管 理";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.AutoSize = true;
            this.PriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceTextBox.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.PriceTextBox.Location = new System.Drawing.Point(109, 175);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(138, 40);
            this.PriceTextBox.TabIndex = 79;
            this.PriceTextBox.Text = "発注ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(69, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 80;
            this.label2.Text = "メーカ名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(713, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 40);
            this.label3.TabIndex = 81;
            this.label3.Text = "発注年月日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(713, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 40);
            this.label4.TabIndex = 82;
            this.label4.Text = "非表示理由";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(29, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 40);
            this.label5.TabIndex = 83;
            this.label5.Text = "発注社員名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(265, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "必須";
            // 
            // textBoxHaID
            // 
            this.textBoxHaID.Location = new System.Drawing.Point(315, 164);
            this.textBoxHaID.Multiline = true;
            this.textBoxHaID.Name = "textBoxHaID";
            this.textBoxHaID.ReadOnly = true;
            this.textBoxHaID.Size = new System.Drawing.Size(206, 51);
            this.textBoxHaID.TabIndex = 85;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(36, 458);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1804, 610);
            this.dataGridViewDsp.TabIndex = 86;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // checkBoxWaWarehouseFlag
            // 
            this.checkBoxWaWarehouseFlag.AutoSize = true;
            this.checkBoxWaWarehouseFlag.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxWaWarehouseFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBoxWaWarehouseFlag.Location = new System.Drawing.Point(720, 374);
            this.checkBoxWaWarehouseFlag.Name = "checkBoxWaWarehouseFlag";
            this.checkBoxWaWarehouseFlag.Size = new System.Drawing.Size(163, 44);
            this.checkBoxWaWarehouseFlag.TabIndex = 87;
            this.checkBoxWaWarehouseFlag.Text = "入庫済";
            this.checkBoxWaWarehouseFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxHaFlag
            // 
            this.checkBoxHaFlag.AutoSize = true;
            this.checkBoxHaFlag.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxHaFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBoxHaFlag.Location = new System.Drawing.Point(924, 373);
            this.checkBoxHaFlag.Name = "checkBoxHaFlag";
            this.checkBoxHaFlag.Size = new System.Drawing.Size(163, 44);
            this.checkBoxHaFlag.TabIndex = 88;
            this.checkBoxHaFlag.Text = "非表示";
            this.checkBoxHaFlag.UseVisualStyleBackColor = true;
            // 
            // textBoxHaHidden
            // 
            this.textBoxHaHidden.Location = new System.Drawing.Point(1028, 265);
            this.textBoxHaHidden.Multiline = true;
            this.textBoxHaHidden.Name = "textBoxHaHidden";
            this.textBoxHaHidden.Size = new System.Drawing.Size(206, 51);
            this.textBoxHaHidden.TabIndex = 91;
            // 
            // dateTimePickerHaDate
            // 
            this.dateTimePickerHaDate.Location = new System.Drawing.Point(1034, 190);
            this.dateTimePickerHaDate.Name = "dateTimePickerHaDate";
            this.dateTimePickerHaDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerHaDate.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(265, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 94;
            this.label7.Text = "必須";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(265, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 95;
            this.label8.Text = "必須";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(984, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 96;
            this.label9.Text = "必須";
            // 
            // button_touroku
            // 
            this.button_touroku.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_touroku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_touroku.Location = new System.Drawing.Point(577, 23);
            this.button_touroku.Name = "button_touroku";
            this.button_touroku.Size = new System.Drawing.Size(141, 50);
            this.button_touroku.TabIndex = 97;
            this.button_touroku.Text = "登録";
            this.button_touroku.UseVisualStyleBackColor = true;
            this.button_touroku.Click += new System.EventHandler(this.button_touroku_Click);
            // 
            // button_koushin
            // 
            this.button_koushin.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_koushin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_koushin.Location = new System.Drawing.Point(769, 23);
            this.button_koushin.Name = "button_koushin";
            this.button_koushin.Size = new System.Drawing.Size(141, 50);
            this.button_koushin.TabIndex = 98;
            this.button_koushin.Text = "更新";
            this.button_koushin.UseVisualStyleBackColor = true;
            this.button_koushin.Click += new System.EventHandler(this.button_koushin_Click);
            // 
            // button_kensaku
            // 
            this.button_kensaku.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_kensaku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_kensaku.Location = new System.Drawing.Point(956, 23);
            this.button_kensaku.Name = "button_kensaku";
            this.button_kensaku.Size = new System.Drawing.Size(141, 50);
            this.button_kensaku.TabIndex = 99;
            this.button_kensaku.Text = "検索";
            this.button_kensaku.UseVisualStyleBackColor = true;
            this.button_kensaku.Click += new System.EventHandler(this.button_kensaku_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("HGS明朝E", 20F);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonClear.Location = new System.Drawing.Point(1354, 23);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(305, 50);
            this.buttonClear.TabIndex = 101;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.button_back.Location = new System.Drawing.Point(1769, 23);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(141, 50);
            this.button_back.TabIndex = 102;
            this.button_back.Text = "戻る";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxMaker
            // 
            this.comboBoxMaker.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxMaker.FormattingEnabled = true;
            this.comboBoxMaker.Location = new System.Drawing.Point(315, 279);
            this.comboBoxMaker.Name = "comboBoxMaker";
            this.comboBoxMaker.Size = new System.Drawing.Size(206, 41);
            this.comboBoxMaker.TabIndex = 103;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(315, 378);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(206, 41);
            this.comboBoxEmployee.TabIndex = 104;
            // 
            // F_hattyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxMaker);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button_kensaku);
            this.Controls.Add(this.button_koushin);
            this.Controls.Add(this.button_touroku);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerHaDate);
            this.Controls.Add(this.textBoxHaHidden);
            this.Controls.Add(this.checkBoxHaFlag);
            this.Controls.Add(this.checkBoxWaWarehouseFlag);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.textBoxHaID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "F_hattyu";
            this.Text = "F_order";
            this.Load += new System.EventHandler(this.F_hattyu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHaID;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.CheckBox checkBoxWaWarehouseFlag;
        private System.Windows.Forms.CheckBox checkBoxHaFlag;
        private System.Windows.Forms.TextBox textBoxHaHidden;
        private System.Windows.Forms.DateTimePicker dateTimePickerHaDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_touroku;
        private System.Windows.Forms.Button button_koushin;
        private System.Windows.Forms.Button button_kensaku;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox comboBoxMaker;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
    }
}