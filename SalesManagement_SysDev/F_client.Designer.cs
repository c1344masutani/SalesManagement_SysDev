
namespace SalesManagement_SysDev
{
    partial class F_client
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
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.checkBoxClflg = new System.Windows.Forms.CheckBox();
            this.textBoxFAX = new System.Windows.Forms.TextBox();
            this.textBoxHidden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSalesOfficeID = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostnumber = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regester_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(35, 442);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1499, 314);
            this.dataGridViewDsp.TabIndex = 44;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            this.dataGridViewDsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellContentClick);
            // 
            // checkBoxClflg
            // 
            this.checkBoxClflg.AutoSize = true;
            this.checkBoxClflg.Location = new System.Drawing.Point(592, 298);
            this.checkBoxClflg.Name = "checkBoxClflg";
            this.checkBoxClflg.Size = new System.Drawing.Size(144, 22);
            this.checkBoxClflg.TabIndex = 43;
            this.checkBoxClflg.Text = "顧客管理フラグ";
            this.checkBoxClflg.UseVisualStyleBackColor = true;
            // 
            // textBoxFAX
            // 
            this.textBoxFAX.Location = new System.Drawing.Point(850, 215);
            this.textBoxFAX.Name = "textBoxFAX";
            this.textBoxFAX.Size = new System.Drawing.Size(100, 25);
            this.textBoxFAX.TabIndex = 42;
            // 
            // textBoxHidden
            // 
            this.textBoxHidden.Location = new System.Drawing.Point(850, 333);
            this.textBoxHidden.Name = "textBoxHidden";
            this.textBoxHidden.Size = new System.Drawing.Size(100, 25);
            this.textBoxHidden.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "非表示理由";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "FAX";
            // 
            // textBoxSalesOfficeID
            // 
            this.textBoxSalesOfficeID.Location = new System.Drawing.Point(289, 212);
            this.textBoxSalesOfficeID.Name = "textBoxSalesOfficeID";
            this.textBoxSalesOfficeID.Size = new System.Drawing.Size(100, 25);
            this.textBoxSalesOfficeID.TabIndex = 38;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(850, 175);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 25);
            this.textBoxTel.TabIndex = 37;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(289, 398);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 25);
            this.textBoxAddress.TabIndex = 36;
            // 
            // textBoxPostnumber
            // 
            this.textBoxPostnumber.Location = new System.Drawing.Point(289, 340);
            this.textBoxPostnumber.Name = "textBoxPostnumber";
            this.textBoxPostnumber.Size = new System.Drawing.Size(100, 25);
            this.textBoxPostnumber.TabIndex = 35;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(289, 275);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(100, 25);
            this.textBoxClientName.TabIndex = 34;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(289, 149);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.ReadOnly = true;
            this.textBoxClientID.Size = new System.Drawing.Size(100, 25);
            this.textBoxClientID.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "電話番号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "住所";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "郵便番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "顧客名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "営業所ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "顧客ID";
            // 
            // Regester_button
            // 
            this.Regester_button.Location = new System.Drawing.Point(63, 80);
            this.Regester_button.Name = "Regester_button";
            this.Regester_button.Size = new System.Drawing.Size(75, 36);
            this.Regester_button.TabIndex = 26;
            this.Regester_button.Text = "追加";
            this.Regester_button.UseVisualStyleBackColor = true;
            this.Regester_button.Click += new System.EventHandler(this.Regester_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(314, 80);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 36);
            this.Update_button.TabIndex = 25;
            this.Update_button.Text = "更新";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(561, 80);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 36);
            this.Delete_button.TabIndex = 24;
            this.Delete_button.Text = "削除";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "顧客管理";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1097, 52);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 33);
            this.buttonClear.TabIndex = 45;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(783, 80);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(82, 36);
            this.Search_button.TabIndex = 46;
            this.Search_button.Text = "検索";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // F_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 768);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.checkBoxClflg);
            this.Controls.Add(this.textBoxFAX);
            this.Controls.Add(this.textBoxHidden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSalesOfficeID);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPostnumber);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regester_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.label1);
            this.Name = "F_client";
            this.Text = "F_client";
            this.Load += new System.EventHandler(this.F_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.CheckBox checkBoxClflg;
        private System.Windows.Forms.TextBox textBoxFAX;
        private System.Windows.Forms.TextBox textBoxHidden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSalesOfficeID;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostnumber;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Regester_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button Search_button;
    }
}