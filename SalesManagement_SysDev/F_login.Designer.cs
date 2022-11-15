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
            this.label_ps = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.PwShow = new System.Windows.Forms.CheckBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.PW_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ps
            // 
            this.label_ps.AutoSize = true;
            this.label_ps.BackColor = System.Drawing.Color.Transparent;
            this.label_ps.Font = new System.Drawing.Font("HGS明朝E", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_ps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label_ps.Location = new System.Drawing.Point(164, 238);
            this.label_ps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ps.Name = "label_ps";
            this.label_ps.Size = new System.Drawing.Size(186, 33);
            this.label_ps.TabIndex = 2;
            this.label_ps.Text = " パスワード";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_ID.Font = new System.Drawing.Font("HGP明朝E", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label_ID.Location = new System.Drawing.Point(226, 80);
            this.label_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(71, 33);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = " I D";
            // 
            // PwShow
            // 
            this.PwShow.AutoSize = true;
            this.PwShow.BackColor = System.Drawing.Color.Transparent;
            this.PwShow.Font = new System.Drawing.Font("HGS明朝E", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PwShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.PwShow.Location = new System.Drawing.Point(170, 368);
            this.PwShow.Margin = new System.Windows.Forms.Padding(4);
            this.PwShow.Name = "PwShow";
            this.PwShow.Size = new System.Drawing.Size(194, 24);
            this.PwShow.TabIndex = 6;
            this.PwShow.Text = "PWを表示/非表示";
            this.PwShow.UseVisualStyleBackColor = false;
            this.PwShow.CheckedChanged += new System.EventHandler(this.PwShow_CheckedChanged);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login_button.Font = new System.Drawing.Font("HGP明朝E", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.Login_button.Location = new System.Drawing.Point(167, 480);
            this.Login_button.Margin = new System.Windows.Forms.Padding(2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(197, 47);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "ログイン";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // PW_textBox
            // 
            this.PW_textBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PW_textBox.Location = new System.Drawing.Point(119, 298);
            this.PW_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PW_textBox.Name = "PW_textBox";
            this.PW_textBox.PasswordChar = '*';
            this.PW_textBox.Size = new System.Drawing.Size(296, 39);
            this.PW_textBox.TabIndex = 4;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ID_textBox.Location = new System.Drawing.Point(119, 144);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(296, 39);
            this.ID_textBox.TabIndex = 3;
            this.ID_textBox.TextChanged += new System.EventHandler(this.ID_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HGS明朝E", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(175, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "新規登録";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Login
            // 
            this.AcceptButton = this.Login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(574, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.PwShow);
            this.Controls.Add(this.PW_textBox);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_ps);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "F_Login";
            this.Text = "販売管理システムログイン画面";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ps;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.CheckBox PwShow;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox PW_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Button button1;
    }
}

