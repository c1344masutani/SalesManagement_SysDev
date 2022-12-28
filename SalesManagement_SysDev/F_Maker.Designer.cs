
namespace SalesManagement_SysDev
{
    partial class F_Maker
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
            this.label1 = new System.Windows.Forms.Label();
            this.Regester_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.checkBoxMaFlag = new System.Windows.Forms.CheckBox();
            this.textBoxHidden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.buttonHidden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(232, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 56);
            this.label1.TabIndex = 92;
            this.label1.Text = "メ ー カ 管 理";
            // 
            // Regester_button
            // 
            this.Regester_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Regester_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.Regester_button.Location = new System.Drawing.Point(662, 34);
            this.Regester_button.Margin = new System.Windows.Forms.Padding(2);
            this.Regester_button.Name = "Regester_button";
            this.Regester_button.Size = new System.Drawing.Size(232, 50);
            this.Regester_button.TabIndex = 93;
            this.Regester_button.Text = "新規追加";
            this.Regester_button.UseVisualStyleBackColor = true;
            this.Regester_button.Click += new System.EventHandler(this.Regester_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.Update_button.Location = new System.Drawing.Point(918, 34);
            this.Update_button.Margin = new System.Windows.Forms.Padding(2);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(141, 50);
            this.Update_button.TabIndex = 94;
            this.Update_button.Text = "更新";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.Search_button.Location = new System.Drawing.Point(1299, 34);
            this.Search_button.Margin = new System.Windows.Forms.Padding(2);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(141, 50);
            this.Search_button.TabIndex = 95;
            this.Search_button.Text = "検索";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.back_button.Location = new System.Drawing.Point(2222, 34);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(140, 50);
            this.back_button.TabIndex = 96;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(51, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 97;
            this.label2.Text = "メーカID";
            // 
            // textBoxMaID
            // 
            this.textBoxMaID.Location = new System.Drawing.Point(288, 176);
            this.textBoxMaID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaID.Multiline = true;
            this.textBoxMaID.Name = "textBoxMaID";
            this.textBoxMaID.ReadOnly = true;
            this.textBoxMaID.Size = new System.Drawing.Size(185, 47);
            this.textBoxMaID.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(51, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 40);
            this.label3.TabIndex = 99;
            this.label3.Text = "メーカ名";
            // 
            // textBoxMaName
            // 
            this.textBoxMaName.Location = new System.Drawing.Point(288, 273);
            this.textBoxMaName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaName.Multiline = true;
            this.textBoxMaName.Name = "textBoxMaName";
            this.textBoxMaName.Size = new System.Drawing.Size(185, 47);
            this.textBoxMaName.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(52, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 40);
            this.label4.TabIndex = 101;
            this.label4.Text = "郵便番号";
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Location = new System.Drawing.Point(288, 374);
            this.textBoxPostal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPostal.Multiline = true;
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(185, 47);
            this.textBoxPostal.TabIndex = 102;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(59, 599);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1804, 440);
            this.dataGridViewDsp.TabIndex = 103;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(51, 473);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 40);
            this.label5.TabIndex = 104;
            this.label5.Text = "住所";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(58, 532);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(415, 47);
            this.textBoxAddress.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(619, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 40);
            this.label6.TabIndex = 106;
            this.label6.Text = "電話番号";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(851, 176);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(388, 47);
            this.textBoxPhone.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(626, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 40);
            this.label7.TabIndex = 108;
            this.label7.Text = "FAX番号";
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(851, 266);
            this.textBoxFax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFax.Multiline = true;
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(388, 47);
            this.textBoxFax.TabIndex = 109;
            // 
            // checkBoxMaFlag
            // 
            this.checkBoxMaFlag.AutoSize = true;
            this.checkBoxMaFlag.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxMaFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.checkBoxMaFlag.Location = new System.Drawing.Point(633, 532);
            this.checkBoxMaFlag.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMaFlag.Name = "checkBoxMaFlag";
            this.checkBoxMaFlag.Size = new System.Drawing.Size(163, 44);
            this.checkBoxMaFlag.TabIndex = 110;
            this.checkBoxMaFlag.Text = "非表示";
            this.checkBoxMaFlag.UseVisualStyleBackColor = true;
            // 
            // textBoxHidden
            // 
            this.textBoxHidden.Location = new System.Drawing.Point(1165, 525);
            this.textBoxHidden.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHidden.Multiline = true;
            this.textBoxHidden.Name = "textBoxHidden";
            this.textBoxHidden.Size = new System.Drawing.Size(505, 47);
            this.textBoxHidden.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(874, 532);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 40);
            this.label8.TabIndex = 111;
            this.label8.Text = "非表示理由";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonBack.Location = new System.Drawing.Point(1829, 34);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 47);
            this.buttonBack.TabIndex = 113;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Transparent;
            this.button_Clear.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_Clear.Location = new System.Drawing.Point(1469, 31);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(321, 50);
            this.button_Clear.TabIndex = 114;
            this.button_Clear.Text = "入力クリア";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // buttonHidden
            // 
            this.buttonHidden.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(68)))));
            this.buttonHidden.Location = new System.Drawing.Point(1089, 34);
            this.buttonHidden.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHidden.Name = "buttonHidden";
            this.buttonHidden.Size = new System.Drawing.Size(171, 50);
            this.buttonHidden.TabIndex = 118;
            this.buttonHidden.Text = "非表示";
            this.buttonHidden.UseVisualStyleBackColor = true;
            this.buttonHidden.Click += new System.EventHandler(this.buttonHidden_Click);
            // 
            // F_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxHidden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxMaFlag);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Regester_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Maker";
            this.Text = "F_Maker";
            this.Load += new System.EventHandler(this.F_Maker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Regester_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.CheckBox checkBoxMaFlag;
        private System.Windows.Forms.TextBox textBoxHidden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button buttonHidden;
    }
}