namespace SalesManagement_SysDev
{
    partial class F_Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CleateDabase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.PW_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.PwShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_CleateDabase
            // 
            this.btn_CleateDabase.Location = new System.Drawing.Point(882, 487);
            this.btn_CleateDabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CleateDabase.Name = "btn_CleateDabase";
            this.btn_CleateDabase.Size = new System.Drawing.Size(142, 62);
            this.btn_CleateDabase.TabIndex = 0;
            this.btn_CleateDabase.Text = "データベース生成";
            this.btn_CleateDabase.UseVisualStyleBackColor = true;
            this.btn_CleateDabase.Click += new System.EventHandler(this.btn_CleateDabase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(334, 134);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(81, 22);
            this.ID_textBox.TabIndex = 3;
            // 
            // PW_textBox
            // 
            this.PW_textBox.Location = new System.Drawing.Point(334, 192);
            this.PW_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PW_textBox.Name = "PW_textBox";
            this.PW_textBox.PasswordChar = '*';
            this.PW_textBox.Size = new System.Drawing.Size(81, 22);
            this.PW_textBox.TabIndex = 4;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(320, 256);
            this.Login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(94, 37);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "ログイン";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // PwShow
            // 
            this.PwShow.AutoSize = true;
            this.PwShow.Location = new System.Drawing.Point(447, 197);
            this.PwShow.Name = "PwShow";
            this.PwShow.Size = new System.Drawing.Size(143, 19);
            this.PwShow.TabIndex = 6;
            this.PwShow.Text = "PWを表示/非表示";
            this.PwShow.UseVisualStyleBackColor = true;
            this.PwShow.CheckedChanged += new System.EventHandler(this.PwShow_CheckedChanged);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 562);
            this.Controls.Add(this.PwShow);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.PW_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CleateDabase);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "F_Login";
            this.Text = "販売管理システムログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CleateDabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox PW_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.CheckBox PwShow;
    }
}

