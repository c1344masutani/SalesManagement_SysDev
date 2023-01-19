
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
            this.buttonSearch = new System.Windows.Forms.Button();
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
            this.labelRequired2 = new System.Windows.Forms.Label();
            this.labelRequired1 = new System.Windows.Forms.Label();
            this.labelRequired5 = new System.Windows.Forms.Label();
            this.labelRequired3 = new System.Windows.Forms.Label();
            this.labelRequired4 = new System.Windows.Forms.Label();
            this.labelRequired6 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonHidden = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxSalesOffice = new System.Windows.Forms.ComboBox();
            this.buttonUpdateMode = new System.Windows.Forms.Button();
            this.buttonSearchMode = new System.Windows.Forms.Button();
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
            this.back_button.Location = new System.Drawing.Point(1760, 31);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 50);
            this.back_button.TabIndex = 52;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonSearch.Location = new System.Drawing.Point(847, 43);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(346, 57);
            this.buttonSearch.TabIndex = 51;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.Search_button_Click);
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
            this.label8.Location = new System.Drawing.Point(918, 417);
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
            this.ShFinishDate.Location = new System.Drawing.Point(918, 332);
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
            this.checkBoxShStateFlag.Location = new System.Drawing.Point(241, 417);
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
            this.checkBoxShFlag.Location = new System.Drawing.Point(538, 417);
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
            this.textBoxShID.ReadOnly = true;
            this.textBoxShID.Size = new System.Drawing.Size(185, 47);
            this.textBoxShID.TabIndex = 64;
            // 
            // textBoxShHidden
            // 
            this.textBoxShHidden.Location = new System.Drawing.Point(1222, 417);
            this.textBoxShHidden.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShHidden.Multiline = true;
            this.textBoxShHidden.Name = "textBoxShHidden";
            this.textBoxShHidden.Size = new System.Drawing.Size(435, 47);
            this.textBoxShHidden.TabIndex = 65;
            // 
            // textBoxOrID
            // 
            this.textBoxOrID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxOrID.Location = new System.Drawing.Point(1222, 240);
            this.textBoxOrID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrID.Multiline = true;
            this.textBoxOrID.Name = "textBoxOrID";
            this.textBoxOrID.ReadOnly = true;
            this.textBoxOrID.Size = new System.Drawing.Size(185, 47);
            this.textBoxOrID.TabIndex = 69;
            // 
            // dateTimePickerShFinishDate
            // 
            this.dateTimePickerShFinishDate.CalendarFont = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerShFinishDate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerShFinishDate.Location = new System.Drawing.Point(1328, 346);
            this.dateTimePickerShFinishDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerShFinishDate.Name = "dateTimePickerShFinishDate";
            this.dateTimePickerShFinishDate.Size = new System.Drawing.Size(273, 39);
            this.dateTimePickerShFinishDate.TabIndex = 70;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(206, 494);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1679, 517);
            this.dataGridViewDsp.TabIndex = 71;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // labelRequired2
            // 
            this.labelRequired2.AutoSize = true;
            this.labelRequired2.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelRequired2.Location = new System.Drawing.Point(386, 269);
            this.labelRequired2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired2.Name = "labelRequired2";
            this.labelRequired2.Size = new System.Drawing.Size(44, 18);
            this.labelRequired2.TabIndex = 72;
            this.labelRequired2.Text = "必須";
            // 
            // labelRequired1
            // 
            this.labelRequired1.AutoSize = true;
            this.labelRequired1.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelRequired1.Location = new System.Drawing.Point(386, 173);
            this.labelRequired1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired1.Name = "labelRequired1";
            this.labelRequired1.Size = new System.Drawing.Size(44, 18);
            this.labelRequired1.TabIndex = 73;
            this.labelRequired1.Text = "必須";
            // 
            // labelRequired5
            // 
            this.labelRequired5.AutoSize = true;
            this.labelRequired5.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelRequired5.Location = new System.Drawing.Point(1061, 274);
            this.labelRequired5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired5.Name = "labelRequired5";
            this.labelRequired5.Size = new System.Drawing.Size(44, 18);
            this.labelRequired5.TabIndex = 74;
            this.labelRequired5.Text = "必須";
            // 
            // labelRequired3
            // 
            this.labelRequired3.AutoSize = true;
            this.labelRequired3.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelRequired3.Location = new System.Drawing.Point(386, 359);
            this.labelRequired3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired3.Name = "labelRequired3";
            this.labelRequired3.Size = new System.Drawing.Size(44, 18);
            this.labelRequired3.TabIndex = 75;
            this.labelRequired3.Text = "必須";
            // 
            // labelRequired4
            // 
            this.labelRequired4.AutoSize = true;
            this.labelRequired4.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelRequired4.Location = new System.Drawing.Point(1112, 169);
            this.labelRequired4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired4.Name = "labelRequired4";
            this.labelRequired4.Size = new System.Drawing.Size(44, 18);
            this.labelRequired4.TabIndex = 76;
            this.labelRequired4.Text = "必須";
            // 
            // labelRequired6
            // 
            this.labelRequired6.AutoSize = true;
            this.labelRequired6.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelRequired6.Location = new System.Drawing.Point(1219, 358);
            this.labelRequired6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequired6.Name = "labelRequired6";
            this.labelRequired6.Size = new System.Drawing.Size(44, 18);
            this.labelRequired6.TabIndex = 77;
            this.labelRequired6.Text = "必須";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonConfirm.Location = new System.Drawing.Point(741, 43);
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
            this.buttonHidden.Location = new System.Drawing.Point(1064, 43);
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
            this.buttonClear.Location = new System.Drawing.Point(1328, 43);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(305, 55);
            this.buttonClear.TabIndex = 119;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(522, 250);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(294, 41);
            this.comboBoxClient.TabIndex = 120;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(522, 335);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(294, 41);
            this.comboBoxEmployee.TabIndex = 121;
            // 
            // comboBoxSalesOffice
            // 
            this.comboBoxSalesOffice.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSalesOffice.FormattingEnabled = true;
            this.comboBoxSalesOffice.Location = new System.Drawing.Point(1222, 146);
            this.comboBoxSalesOffice.Name = "comboBoxSalesOffice";
            this.comboBoxSalesOffice.Size = new System.Drawing.Size(306, 41);
            this.comboBoxSalesOffice.TabIndex = 122;
            // 
            // buttonUpdateMode
            // 
            this.buttonUpdateMode.BackColor = System.Drawing.Color.LightYellow;
            this.buttonUpdateMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpdateMode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonUpdateMode.Location = new System.Drawing.Point(45, 150);
            this.buttonUpdateMode.Name = "buttonUpdateMode";
            this.buttonUpdateMode.Size = new System.Drawing.Size(98, 82);
            this.buttonUpdateMode.TabIndex = 123;
            this.buttonUpdateMode.Text = "更新\r\nモード";
            this.buttonUpdateMode.UseVisualStyleBackColor = false;
            this.buttonUpdateMode.Click += new System.EventHandler(this.buttonUpdateMode_Click);
            // 
            // buttonSearchMode
            // 
            this.buttonSearchMode.BackColor = System.Drawing.Color.Orange;
            this.buttonSearchMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearchMode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearchMode.Location = new System.Drawing.Point(45, 290);
            this.buttonSearchMode.Name = "buttonSearchMode";
            this.buttonSearchMode.Size = new System.Drawing.Size(98, 82);
            this.buttonSearchMode.TabIndex = 124;
            this.buttonSearchMode.Text = "検索\r\nモード";
            this.buttonSearchMode.UseVisualStyleBackColor = false;
            this.buttonSearchMode.Click += new System.EventHandler(this.buttonSearchMode_Click);
            // 
            // F_syukka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.buttonSearchMode);
            this.Controls.Add(this.buttonUpdateMode);
            this.Controls.Add(this.comboBoxSalesOffice);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelRequired6);
            this.Controls.Add(this.labelRequired4);
            this.Controls.Add(this.labelRequired3);
            this.Controls.Add(this.labelRequired5);
            this.Controls.Add(this.labelRequired1);
            this.Controls.Add(this.labelRequired2);
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
            this.Controls.Add(this.buttonSearch);
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
        private System.Windows.Forms.Button buttonSearch;
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
        private System.Windows.Forms.Label labelRequired2;
        private System.Windows.Forms.Label labelRequired1;
        private System.Windows.Forms.Label labelRequired5;
        private System.Windows.Forms.Label labelRequired3;
        private System.Windows.Forms.Label labelRequired4;
        private System.Windows.Forms.Label labelRequired6;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonHidden;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxSalesOffice;
        private System.Windows.Forms.Button buttonUpdateMode;
        private System.Windows.Forms.Button buttonSearchMode;
    }
}