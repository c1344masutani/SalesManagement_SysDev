﻿
namespace SalesManagement_SysDev
{
    partial class client
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
            this.Search_button = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.Regester_button = new System.Windows.Forms.Button();
            this.textBoxSalesOfficeID = new System.Windows.Forms.TextBox();
            this.textBoxFAX = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.checkBoxClflg = new System.Windows.Forms.CheckBox();
            this.textBoxPostnumber = new System.Windows.Forms.TextBox();
            this.textBoxHidden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Search_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.Search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_button.Location = new System.Drawing.Point(1540, 31);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(140, 50);
            this.Search_button.TabIndex = 46;
            this.Search_button.Text = "検索";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPhone.Location = new System.Drawing.Point(1194, 140);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(254, 43);
            this.textBoxPhone.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HGP明朝E", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(313, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 56);
            this.label1.TabIndex = 23;
            this.label1.Text = "顧 客 管 理";
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Update_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.Update_button.Location = new System.Drawing.Point(1018, 31);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(141, 50);
            this.Update_button.TabIndex = 25;
            this.Update_button.Text = "更新";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Delete_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delete_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_button.Location = new System.Drawing.Point(1281, 30);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(141, 53);
            this.Delete_button.TabIndex = 24;
            this.Delete_button.Text = "削除";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxClientID.Location = new System.Drawing.Point(523, 147);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.ReadOnly = true;
            this.textBoxClientID.Size = new System.Drawing.Size(185, 47);
            this.textBoxClientID.TabIndex = 33;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAddress.Location = new System.Drawing.Point(1194, 309);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(761, 43);
            this.textBoxAddress.TabIndex = 36;
            // 
            // Regester_button
            // 
            this.Regester_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Regester_button.Font = new System.Drawing.Font("HGP明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Regester_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.Regester_button.Location = new System.Drawing.Point(716, 30);
            this.Regester_button.Name = "Regester_button";
            this.Regester_button.Size = new System.Drawing.Size(220, 50);
            this.Regester_button.TabIndex = 26;
            this.Regester_button.Text = "新規追加";
            this.Regester_button.UseVisualStyleBackColor = false;
            this.Regester_button.Click += new System.EventHandler(this.Regester_button_Click);
            // 
            // textBoxSalesOfficeID
            // 
            this.textBoxSalesOfficeID.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSalesOfficeID.Location = new System.Drawing.Point(523, 227);
            this.textBoxSalesOfficeID.Name = "textBoxSalesOfficeID";
            this.textBoxSalesOfficeID.Size = new System.Drawing.Size(185, 43);
            this.textBoxSalesOfficeID.TabIndex = 38;
            // 
            // textBoxFAX
            // 
            this.textBoxFAX.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFAX.Location = new System.Drawing.Point(1681, 133);
            this.textBoxFAX.Name = "textBoxFAX";
            this.textBoxFAX.Size = new System.Drawing.Size(267, 47);
            this.textBoxFAX.TabIndex = 42;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxClientName.Location = new System.Drawing.Point(523, 312);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(274, 43);
            this.textBoxClientName.TabIndex = 34;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(144, 472);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1804, 610);
            this.dataGridViewDsp.TabIndex = 44;
            this.dataGridViewDsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellContentClick);
            // 
            // checkBoxClflg
            // 
            this.checkBoxClflg.AutoSize = true;
            this.checkBoxClflg.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxClflg.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxClflg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.checkBoxClflg.Location = new System.Drawing.Point(1565, 386);
            this.checkBoxClflg.Name = "checkBoxClflg";
            this.checkBoxClflg.Size = new System.Drawing.Size(163, 44);
            this.checkBoxClflg.TabIndex = 43;
            this.checkBoxClflg.Text = "非表示";
            this.checkBoxClflg.UseVisualStyleBackColor = false;
            // 
            // textBoxPostnumber
            // 
            this.textBoxPostnumber.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPostnumber.Location = new System.Drawing.Point(1194, 234);
            this.textBoxPostnumber.Name = "textBoxPostnumber";
            this.textBoxPostnumber.Size = new System.Drawing.Size(212, 43);
            this.textBoxPostnumber.TabIndex = 37;
            // 
            // textBoxHidden
            // 
            this.textBoxHidden.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxHidden.Location = new System.Drawing.Point(523, 390);
            this.textBoxHidden.Name = "textBoxHidden";
            this.textBoxHidden.Size = new System.Drawing.Size(302, 43);
            this.textBoxHidden.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(234, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "顧客ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(918, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 40);
            this.label6.TabIndex = 31;
            this.label6.Text = "住所";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label10.Location = new System.Drawing.Point(234, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 40);
            this.label10.TabIndex = 40;
            this.label10.Text = "非表示理由";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(918, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 40);
            this.label5.TabIndex = 30;
            this.label5.Text = "郵便番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(235, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "顧客名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(235, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 40);
            this.label3.TabIndex = 28;
            this.label3.Text = "営業所ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(1533, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 40);
            this.label8.TabIndex = 39;
            this.label8.Text = "FAX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(918, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 40);
            this.label7.TabIndex = 32;
            this.label7.Text = "電話番号";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClear.Location = new System.Drawing.Point(745, -195);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(465, 114);
            this.buttonClear.TabIndex = 50;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.button1.Location = new System.Drawing.Point(1808, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 51;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label9.Location = new System.Drawing.Point(378, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "必須";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label11.Location = new System.Drawing.Point(419, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "必須";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label12.Location = new System.Drawing.Point(1101, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 54;
            this.label12.Text = "必須";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label13.Location = new System.Drawing.Point(1101, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "必須";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label14.Location = new System.Drawing.Point(1021, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 56;
            this.label14.Text = "必須";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label15.Location = new System.Drawing.Point(378, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 18);
            this.label15.TabIndex = 57;
            this.label15.Text = "必須";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label16.Location = new System.Drawing.Point(1617, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 18);
            this.label16.TabIndex = 58;
            this.label16.Text = "必須";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxSalesOfficeID);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxHidden);
            this.Controls.Add(this.textBoxPostnumber);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxFAX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Regester_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxClflg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Name = "client";
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button Regester_button;
        private System.Windows.Forms.TextBox textBoxSalesOfficeID;
        private System.Windows.Forms.TextBox textBoxFAX;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.CheckBox checkBoxClflg;
        private System.Windows.Forms.TextBox textBoxPostnumber;
        private System.Windows.Forms.TextBox textBoxHidden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}