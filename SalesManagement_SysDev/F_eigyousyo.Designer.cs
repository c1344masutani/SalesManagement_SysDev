
namespace SalesManagement_SysDev
{
    partial class F_eigyousyo
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
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxSoFlag = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSoID = new System.Windows.Forms.TextBox();
            this.textBoxSoName = new System.Windows.Forms.TextBox();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxHidden = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.buttonHidden = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelRequired1 = new System.Windows.Forms.Label();
            this.labelRequired2 = new System.Windows.Forms.Label();
            this.labelRequired3 = new System.Windows.Forms.Label();
            this.labelRequired4 = new System.Windows.Forms.Label();
            this.labelRequired5 = new System.Windows.Forms.Label();
            this.labelRequired6 = new System.Windows.Forms.Label();
            this.buttonSearchMode = new System.Windows.Forms.Button();
            this.buttonUpdateMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HGS明朝E", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(294, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(380, 56);
            this.label9.TabIndex = 50;
            this.label9.Text = "営 業 所 管 理";
            // 
            // buttonRegester
            // 
            this.buttonRegester.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRegester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonRegester.Location = new System.Drawing.Point(788, 33);
            this.buttonRegester.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(218, 50);
            this.buttonRegester.TabIndex = 51;
            this.buttonRegester.Text = "新規追加";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.Regester_button_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonUpdate.Location = new System.Drawing.Point(1073, 33);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(141, 50);
            this.buttonUpdate.TabIndex = 52;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonSearch.Location = new System.Drawing.Point(924, 33);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(419, 50);
            this.buttonSearch.TabIndex = 53;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.back_button.Location = new System.Drawing.Point(1831, 30);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 50);
            this.back_button.TabIndex = 54;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(253, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 55;
            this.label1.Text = "営業所ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(254, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 56;
            this.label2.Text = "営業所名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(254, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 57;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(1029, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 40);
            this.label4.TabIndex = 58;
            this.label4.Text = "電話番号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(253, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 40);
            this.label5.TabIndex = 59;
            this.label5.Text = "郵便番号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(1036, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 40);
            this.label6.TabIndex = 60;
            this.label6.Text = "FAX番号";
            // 
            // checkBoxSoFlag
            // 
            this.checkBoxSoFlag.AutoSize = true;
            this.checkBoxSoFlag.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxSoFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBoxSoFlag.Location = new System.Drawing.Point(966, 466);
            this.checkBoxSoFlag.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSoFlag.Name = "checkBoxSoFlag";
            this.checkBoxSoFlag.Size = new System.Drawing.Size(163, 44);
            this.checkBoxSoFlag.TabIndex = 61;
            this.checkBoxSoFlag.Text = "非表示";
            this.checkBoxSoFlag.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(1196, 466);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 40);
            this.label8.TabIndex = 62;
            this.label8.Text = "非表示理由";
            // 
            // textBoxSoID
            // 
            this.textBoxSoID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSoID.Location = new System.Drawing.Point(534, 163);
            this.textBoxSoID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSoID.Multiline = true;
            this.textBoxSoID.Name = "textBoxSoID";
            this.textBoxSoID.ReadOnly = true;
            this.textBoxSoID.Size = new System.Drawing.Size(201, 47);
            this.textBoxSoID.TabIndex = 63;
            // 
            // textBoxSoName
            // 
            this.textBoxSoName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSoName.Location = new System.Drawing.Point(534, 243);
            this.textBoxSoName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSoName.Multiline = true;
            this.textBoxSoName.Name = "textBoxSoName";
            this.textBoxSoName.Size = new System.Drawing.Size(292, 47);
            this.textBoxSoName.TabIndex = 64;
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPostal.Location = new System.Drawing.Point(534, 320);
            this.textBoxPostal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPostal.Multiline = true;
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(232, 47);
            this.textBoxPostal.TabIndex = 65;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAddress.Location = new System.Drawing.Point(261, 463);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(565, 47);
            this.textBoxAddress.TabIndex = 66;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPhone.Location = new System.Drawing.Point(1297, 152);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(275, 47);
            this.textBoxPhone.TabIndex = 67;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFax.Location = new System.Drawing.Point(1297, 245);
            this.textBoxFax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFax.Multiline = true;
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(275, 47);
            this.textBoxFax.TabIndex = 68;
            // 
            // textBoxHidden
            // 
            this.textBoxHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxHidden.Location = new System.Drawing.Point(1469, 459);
            this.textBoxHidden.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHidden.Multiline = true;
            this.textBoxHidden.Name = "textBoxHidden";
            this.textBoxHidden.Size = new System.Drawing.Size(505, 47);
            this.textBoxHidden.TabIndex = 69;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(71, 564);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1804, 440);
            this.dataGridViewDsp.TabIndex = 70;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // buttonHidden
            // 
            this.buttonHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHidden.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonHidden.Location = new System.Drawing.Point(1281, 30);
            this.buttonHidden.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHidden.Name = "buttonHidden";
            this.buttonHidden.Size = new System.Drawing.Size(179, 50);
            this.buttonHidden.TabIndex = 105;
            this.buttonHidden.Text = "非表示";
            this.buttonHidden.UseVisualStyleBackColor = false;
            this.buttonHidden.Click += new System.EventHandler(this.buttonHidden_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonClear.Location = new System.Drawing.Point(1525, 33);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(271, 50);
            this.buttonClear.TabIndex = 106;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelRequired1
            // 
            this.labelRequired1.AutoSize = true;
            this.labelRequired1.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired1.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired1.ForeColor = System.Drawing.Color.Red;
            this.labelRequired1.Location = new System.Drawing.Point(436, 189);
            this.labelRequired1.Name = "labelRequired1";
            this.labelRequired1.Size = new System.Drawing.Size(44, 18);
            this.labelRequired1.TabIndex = 107;
            this.labelRequired1.Text = "必須";
            // 
            // labelRequired2
            // 
            this.labelRequired2.AutoSize = true;
            this.labelRequired2.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired2.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired2.ForeColor = System.Drawing.Color.Red;
            this.labelRequired2.Location = new System.Drawing.Point(436, 265);
            this.labelRequired2.Name = "labelRequired2";
            this.labelRequired2.Size = new System.Drawing.Size(44, 18);
            this.labelRequired2.TabIndex = 108;
            this.labelRequired2.Text = "必須";
            // 
            // labelRequired3
            // 
            this.labelRequired3.AutoSize = true;
            this.labelRequired3.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired3.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired3.ForeColor = System.Drawing.Color.Red;
            this.labelRequired3.Location = new System.Drawing.Point(436, 342);
            this.labelRequired3.Name = "labelRequired3";
            this.labelRequired3.Size = new System.Drawing.Size(44, 18);
            this.labelRequired3.TabIndex = 109;
            this.labelRequired3.Text = "必須";
            // 
            // labelRequired4
            // 
            this.labelRequired4.AutoSize = true;
            this.labelRequired4.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired4.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired4.ForeColor = System.Drawing.Color.Red;
            this.labelRequired4.Location = new System.Drawing.Point(1211, 181);
            this.labelRequired4.Name = "labelRequired4";
            this.labelRequired4.Size = new System.Drawing.Size(44, 18);
            this.labelRequired4.TabIndex = 110;
            this.labelRequired4.Text = "必須";
            // 
            // labelRequired5
            // 
            this.labelRequired5.AutoSize = true;
            this.labelRequired5.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired5.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired5.ForeColor = System.Drawing.Color.Red;
            this.labelRequired5.Location = new System.Drawing.Point(1211, 268);
            this.labelRequired5.Name = "labelRequired5";
            this.labelRequired5.Size = new System.Drawing.Size(44, 18);
            this.labelRequired5.TabIndex = 111;
            this.labelRequired5.Text = "必須";
            // 
            // labelRequired6
            // 
            this.labelRequired6.AutoSize = true;
            this.labelRequired6.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired6.Font = new System.Drawing.Font("HGS明朝E", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRequired6.ForeColor = System.Drawing.Color.Red;
            this.labelRequired6.Location = new System.Drawing.Point(356, 418);
            this.labelRequired6.Name = "labelRequired6";
            this.labelRequired6.Size = new System.Drawing.Size(44, 18);
            this.labelRequired6.TabIndex = 112;
            this.labelRequired6.Text = "必須";
            // 
            // buttonSearchMode
            // 
            this.buttonSearchMode.BackColor = System.Drawing.Color.Orange;
            this.buttonSearchMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearchMode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearchMode.Location = new System.Drawing.Point(37, 310);
            this.buttonSearchMode.Name = "buttonSearchMode";
            this.buttonSearchMode.Size = new System.Drawing.Size(98, 82);
            this.buttonSearchMode.TabIndex = 130;
            this.buttonSearchMode.Text = "検索\r\nモード";
            this.buttonSearchMode.UseVisualStyleBackColor = false;
            this.buttonSearchMode.Click += new System.EventHandler(this.buttonSearchMode_Click);
            // 
            // buttonUpdateMode
            // 
            this.buttonUpdateMode.BackColor = System.Drawing.Color.LightYellow;
            this.buttonUpdateMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpdateMode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonUpdateMode.Location = new System.Drawing.Point(37, 170);
            this.buttonUpdateMode.Name = "buttonUpdateMode";
            this.buttonUpdateMode.Size = new System.Drawing.Size(98, 82);
            this.buttonUpdateMode.TabIndex = 129;
            this.buttonUpdateMode.Text = "更新\r\nモード";
            this.buttonUpdateMode.UseVisualStyleBackColor = false;
            this.buttonUpdateMode.Click += new System.EventHandler(this.buttonUpdateMode_Click);
            // 
            // F_eigyousyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.buttonSearchMode);
            this.Controls.Add(this.buttonUpdateMode);
            this.Controls.Add(this.labelRequired6);
            this.Controls.Add(this.labelRequired5);
            this.Controls.Add(this.labelRequired4);
            this.Controls.Add(this.labelRequired3);
            this.Controls.Add(this.labelRequired2);
            this.Controls.Add(this.labelRequired1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.textBoxHidden);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.textBoxSoName);
            this.Controls.Add(this.textBoxSoID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxSoFlag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegester);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Name = "F_eigyousyo";
            this.Text = "F_eigyousyo";
            this.Load += new System.EventHandler(this.F_eigyousyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRegester;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSoFlag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSoID;
        private System.Windows.Forms.TextBox textBoxSoName;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxHidden;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button buttonHidden;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelRequired1;
        private System.Windows.Forms.Label labelRequired2;
        private System.Windows.Forms.Label labelRequired3;
        private System.Windows.Forms.Label labelRequired4;
        private System.Windows.Forms.Label labelRequired5;
        private System.Windows.Forms.Label labelRequired6;
        private System.Windows.Forms.Button buttonSearchMode;
        private System.Windows.Forms.Button buttonUpdateMode;
    }
}