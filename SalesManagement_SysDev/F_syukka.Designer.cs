
namespace SalesManagement_SysDev
{
    partial class F_syukka
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrID = new System.Windows.Forms.Label();
            this.EmID = new System.Windows.Forms.Label();
            this.ClID = new System.Windows.Forms.Label();
            this.ShID = new System.Windows.Forms.Label();
            this.SoID = new System.Windows.Forms.Label();
            this.ShFinishDate = new System.Windows.Forms.Label();
            this.checkBoxShStateFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxShFlag = new System.Windows.Forms.CheckBox();
            this.textBoxShID = new System.Windows.Forms.TextBox();
            this.textBoxShHidden = new System.Windows.Forms.TextBox();
            this.textBoxOrID = new System.Windows.Forms.TextBox();
            this.dateTimePickerShFinishDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonHidden = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxSalesOffice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.Location = new System.Drawing.Point(30, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.back_button.Location = new System.Drawing.Point(1762, 48);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 50);
            this.back_button.TabIndex = 52;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.Search_button.Location = new System.Drawing.Point(713, 29);
            this.Search_button.Margin = new System.Windows.Forms.Padding(2);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(141, 57);
            this.Search_button.TabIndex = 51;
            this.Search_button.Text = "検索";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HGS明朝E", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(315, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 56);
            this.label9.TabIndex = 49;
            this.label9.Text = "出 荷 管 理";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(234, 414);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 40);
            this.label8.TabIndex = 58;
            this.label8.Text = "非表示理由";
            // 
            // OrID
            // 
            this.OrID.AutoSize = true;
            this.OrID.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.OrID.Location = new System.Drawing.Point(918, 251);
            this.OrID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrID.Name = "OrID";
            this.OrID.Size = new System.Drawing.Size(138, 40);
            this.OrID.TabIndex = 57;
            this.OrID.Text = "受注ID";
            // 
            // EmID
            // 
            this.EmID.AutoSize = true;
            this.EmID.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.EmID.Location = new System.Drawing.Point(234, 336);
            this.EmID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(137, 40);
            this.EmID.TabIndex = 56;
            this.EmID.Text = "社員名";
            // 
            // ClID
            // 
            this.ClID.AutoSize = true;
            this.ClID.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.ClID.Location = new System.Drawing.Point(234, 251);
            this.ClID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClID.Name = "ClID";
            this.ClID.Size = new System.Drawing.Size(137, 40);
            this.ClID.TabIndex = 55;
            this.ClID.Text = "顧客名";
            // 
            // ShID
            // 
            this.ShID.AutoSize = true;
            this.ShID.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.ShID.Location = new System.Drawing.Point(234, 150);
            this.ShID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShID.Name = "ShID";
            this.ShID.Size = new System.Drawing.Size(138, 40);
            this.ShID.TabIndex = 54;
            this.ShID.Text = "出荷ID";
            // 
            // SoID
            // 
            this.SoID.AutoSize = true;
            this.SoID.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.SoID.Location = new System.Drawing.Point(918, 146);
            this.SoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoID.Name = "SoID";
            this.SoID.Size = new System.Drawing.Size(177, 40);
            this.SoID.TabIndex = 59;
            this.SoID.Text = "営業所名";
            // 
            // ShFinishDate
            // 
            this.ShFinishDate.AutoSize = true;
            this.ShFinishDate.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShFinishDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.ShFinishDate.Location = new System.Drawing.Point(918, 414);
            this.ShFinishDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShFinishDate.Name = "ShFinishDate";
            this.ShFinishDate.Size = new System.Drawing.Size(297, 40);
            this.ShFinishDate.TabIndex = 61;
            this.ShFinishDate.Text = "出荷完了年月日";
            // 
            // checkBoxShStateFlag
            // 
            this.checkBoxShStateFlag.AutoSize = true;
            this.checkBoxShStateFlag.Font = new System.Drawing.Font("HGS明朝E", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxShStateFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBoxShStateFlag.Location = new System.Drawing.Point(925, 354);
            this.checkBoxShStateFlag.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShStateFlag.Name = "checkBoxShStateFlag";
            this.checkBoxShStateFlag.Size = new System.Drawing.Size(185, 40);
            this.checkBoxShStateFlag.TabIndex = 62;
            this.checkBoxShStateFlag.Text = "出荷確定";
            this.checkBoxShStateFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxShFlag
            // 
            this.checkBoxShFlag.AutoSize = true;
            this.checkBoxShFlag.Font = new System.Drawing.Font("HGS明朝E", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxShFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBoxShFlag.Location = new System.Drawing.Point(1222, 354);
            this.checkBoxShFlag.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShFlag.Name = "checkBoxShFlag";
            this.checkBoxShFlag.Size = new System.Drawing.Size(149, 40);
            this.checkBoxShFlag.TabIndex = 63;
            this.checkBoxShFlag.Text = "非表示";
            this.checkBoxShFlag.UseVisualStyleBackColor = true;
            // 
            // textBoxShID
            // 
            this.textBoxShID.Location = new System.Drawing.Point(522, 143);
            this.textBoxShID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShID.Multiline = true;
            this.textBoxShID.Name = "textBoxShID";
            this.textBoxShID.Size = new System.Drawing.Size(185, 47);
            this.textBoxShID.TabIndex = 64;
            // 
            // textBoxShHidden
            // 
            this.textBoxShHidden.Location = new System.Drawing.Point(522, 414);
            this.textBoxShHidden.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShHidden.Multiline = true;
            this.textBoxShHidden.Name = "textBoxShHidden";
            this.textBoxShHidden.Size = new System.Drawing.Size(185, 47);
            this.textBoxShHidden.TabIndex = 65;
            // 
            // textBoxOrID
            // 
            this.textBoxOrID.Location = new System.Drawing.Point(1222, 258);
            this.textBoxOrID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrID.Multiline = true;
            this.textBoxOrID.Name = "textBoxOrID";
            this.textBoxOrID.Size = new System.Drawing.Size(185, 47);
            this.textBoxOrID.TabIndex = 69;
            // 
            // dateTimePickerShFinishDate
            // 
            this.dateTimePickerShFinishDate.Location = new System.Drawing.Point(1300, 425);
            this.dateTimePickerShFinishDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerShFinishDate.Name = "dateTimePickerShFinishDate";
            this.dateTimePickerShFinishDate.Size = new System.Drawing.Size(185, 25);
            this.dateTimePickerShFinishDate.TabIndex = 70;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(192, 492);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1679, 517);
            this.dataGridViewDsp.TabIndex = 71;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label10.Location = new System.Drawing.Point(386, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 72;
            this.label10.Text = "必須";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(386, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "必須";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(1061, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "必須";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(386, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "必須";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(1112, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "必須";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(1236, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "必須";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonConfirm.Location = new System.Drawing.Point(876, 31);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(220, 55);
            this.buttonConfirm.TabIndex = 117;
            this.buttonConfirm.Text = "出荷確定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonHidden
            // 
            this.buttonHidden.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonHidden.Location = new System.Drawing.Point(1115, 31);
            this.buttonHidden.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHidden.Name = "buttonHidden";
            this.buttonHidden.Size = new System.Drawing.Size(171, 55);
            this.buttonHidden.TabIndex = 118;
            this.buttonHidden.Text = "非表示";
            this.buttonHidden.UseVisualStyleBackColor = true;
            this.buttonHidden.Click += new System.EventHandler(this.buttonHidden_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("HGS明朝E", 20F);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonClear.Location = new System.Drawing.Point(1328, 29);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(305, 57);
            this.buttonClear.TabIndex = 119;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(522, 258);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(185, 41);
            this.comboBoxClient.TabIndex = 120;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(522, 335);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(185, 41);
            this.comboBoxEmployee.TabIndex = 121;
            // 
            // comboBoxSalesOffice
            // 
            this.comboBoxSalesOffice.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSalesOffice.FormattingEnabled = true;
            this.comboBoxSalesOffice.Location = new System.Drawing.Point(1222, 146);
            this.comboBoxSalesOffice.Name = "comboBoxSalesOffice";
            this.comboBoxSalesOffice.Size = new System.Drawing.Size(185, 41);
            this.comboBoxSalesOffice.TabIndex = 122;
            // 
            // F_syukka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.comboBoxSalesOffice);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.dateTimePickerShFinishDate);
            this.Controls.Add(this.textBoxOrID);
            this.Controls.Add(this.textBoxShHidden);
            this.Controls.Add(this.textBoxShID);
            this.Controls.Add(this.checkBoxShFlag);
            this.Controls.Add(this.checkBoxShStateFlag);
            this.Controls.Add(this.ShFinishDate);
            this.Controls.Add(this.SoID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OrID);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.ClID);
            this.Controls.Add(this.ShID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_syukka";
            this.Text = "shipping";
            this.Load += new System.EventHandler(this.F_syukka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label OrID;
        private System.Windows.Forms.Label EmID;
        private System.Windows.Forms.Label ClID;
        private System.Windows.Forms.Label ShID;
        private System.Windows.Forms.Label SoID;
        private System.Windows.Forms.Label ShFinishDate;
        private System.Windows.Forms.CheckBox checkBoxShStateFlag;
        private System.Windows.Forms.CheckBox checkBoxShFlag;
        private System.Windows.Forms.TextBox textBoxShID;
        private System.Windows.Forms.TextBox textBoxShHidden;
        private System.Windows.Forms.TextBox textBoxOrID;
        private System.Windows.Forms.DateTimePicker dateTimePickerShFinishDate;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonHidden;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxSalesOffice;
    }
}