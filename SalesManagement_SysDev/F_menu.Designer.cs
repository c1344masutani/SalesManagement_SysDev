
namespace SalesManagement_SysDev
{
    partial class F_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonShipment = new System.Windows.Forms.Button();
            this.buttonChumon = new System.Windows.Forms.Button();
            this.buttonArrival = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonSyukko = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonHattyu = new System.Windows.Forms.Button();
            this.buttonWarehousing = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.labelLoginName);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonShipment);
            this.panel1.Controls.Add(this.buttonChumon);
            this.panel1.Controls.Add(this.buttonArrival);
            this.panel1.Controls.Add(this.buttonProduct);
            this.panel1.Controls.Add(this.buttonOrder);
            this.panel1.Controls.Add(this.buttonSyukko);
            this.panel1.Controls.Add(this.buttonSale);
            this.panel1.Controls.Add(this.buttonHattyu);
            this.panel1.Controls.Add(this.buttonWarehousing);
            this.panel1.Controls.Add(this.buttonStock);
            this.panel1.Controls.Add(this.buttonEmployee);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Font = new System.Drawing.Font("HGS明朝E", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonLogout.Location = new System.Drawing.Point(1538, 103);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(321, 59);
            this.buttonLogout.TabIndex = 94;
            this.buttonLogout.Text = "ログアウト";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(891, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 74);
            this.label1.TabIndex = 24;
            this.label1.Text = "メニュー";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources.S__33333256;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(49, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonClient.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(291, 230);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(278, 136);
            this.buttonClient.TabIndex = 12;
            this.buttonClient.Text = "顧客管理";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.Customer_button_Click);
            // 
            // buttonShipment
            // 
            this.buttonShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonShipment.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonShipment.ForeColor = System.Drawing.Color.White;
            this.buttonShipment.Location = new System.Drawing.Point(1581, 710);
            this.buttonShipment.Name = "buttonShipment";
            this.buttonShipment.Size = new System.Drawing.Size(278, 136);
            this.buttonShipment.TabIndex = 23;
            this.buttonShipment.Text = "出荷管理";
            this.buttonShipment.UseVisualStyleBackColor = false;
            this.buttonShipment.Click += new System.EventHandler(this.OutGoodsbutton_Click);
            // 
            // buttonChumon
            // 
            this.buttonChumon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonChumon.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonChumon.ForeColor = System.Drawing.Color.White;
            this.buttonChumon.Location = new System.Drawing.Point(1150, 460);
            this.buttonChumon.Name = "buttonChumon";
            this.buttonChumon.Size = new System.Drawing.Size(278, 136);
            this.buttonChumon.TabIndex = 18;
            this.buttonChumon.Text = "注文管理";
            this.buttonChumon.UseVisualStyleBackColor = false;
            this.buttonChumon.Click += new System.EventHandler(this.Order_button_Click);
            // 
            // buttonArrival
            // 
            this.buttonArrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonArrival.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonArrival.ForeColor = System.Drawing.Color.White;
            this.buttonArrival.Location = new System.Drawing.Point(1150, 710);
            this.buttonArrival.Name = "buttonArrival";
            this.buttonArrival.Size = new System.Drawing.Size(278, 136);
            this.buttonArrival.TabIndex = 22;
            this.buttonArrival.Text = "入荷管理";
            this.buttonArrival.UseVisualStyleBackColor = false;
            this.buttonArrival.Click += new System.EventHandler(this.InGoods_button_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonProduct.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonProduct.ForeColor = System.Drawing.Color.White;
            this.buttonProduct.Location = new System.Drawing.Point(710, 230);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(278, 136);
            this.buttonProduct.TabIndex = 13;
            this.buttonProduct.Text = "商品管理";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.Goods_button_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonOrder.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(710, 459);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(278, 136);
            this.buttonOrder.TabIndex = 17;
            this.buttonOrder.Text = "受注管理";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.Received_button_Click);
            // 
            // buttonSyukko
            // 
            this.buttonSyukko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonSyukko.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSyukko.ForeColor = System.Drawing.Color.White;
            this.buttonSyukko.Location = new System.Drawing.Point(710, 710);
            this.buttonSyukko.Name = "buttonSyukko";
            this.buttonSyukko.Size = new System.Drawing.Size(278, 136);
            this.buttonSyukko.TabIndex = 21;
            this.buttonSyukko.Text = "出庫管理";
            this.buttonSyukko.UseVisualStyleBackColor = false;
            this.buttonSyukko.Click += new System.EventHandler(this.OutHouse_button_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonSale.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSale.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSale.Location = new System.Drawing.Point(291, 459);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(278, 136);
            this.buttonSale.TabIndex = 16;
            this.buttonSale.Text = "売上管理";
            this.buttonSale.UseVisualStyleBackColor = false;
            this.buttonSale.Click += new System.EventHandler(this.Profit_button_Click);
            // 
            // buttonHattyu
            // 
            this.buttonHattyu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonHattyu.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHattyu.ForeColor = System.Drawing.Color.White;
            this.buttonHattyu.Location = new System.Drawing.Point(1581, 459);
            this.buttonHattyu.Name = "buttonHattyu";
            this.buttonHattyu.Size = new System.Drawing.Size(278, 136);
            this.buttonHattyu.TabIndex = 19;
            this.buttonHattyu.Text = "発注管理";
            this.buttonHattyu.UseVisualStyleBackColor = false;
            this.buttonHattyu.Click += new System.EventHandler(this.HOrder_button_Click);
            // 
            // buttonWarehousing
            // 
            this.buttonWarehousing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonWarehousing.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonWarehousing.ForeColor = System.Drawing.Color.White;
            this.buttonWarehousing.Location = new System.Drawing.Point(291, 710);
            this.buttonWarehousing.Name = "buttonWarehousing";
            this.buttonWarehousing.Size = new System.Drawing.Size(278, 136);
            this.buttonWarehousing.TabIndex = 20;
            this.buttonWarehousing.Text = "入庫管理";
            this.buttonWarehousing.UseVisualStyleBackColor = false;
            this.buttonWarehousing.Click += new System.EventHandler(this.InHouse_button_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonStock.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStock.ForeColor = System.Drawing.Color.White;
            this.buttonStock.Location = new System.Drawing.Point(1150, 230);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(278, 136);
            this.buttonStock.TabIndex = 14;
            this.buttonStock.Text = "在庫管理";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.Stock_button_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(123)))), ((int)(((byte)(87)))));
            this.buttonEmployee.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonEmployee.Location = new System.Drawing.Point(1581, 230);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(278, 136);
            this.buttonEmployee.TabIndex = 15;
            this.buttonEmployee.Text = "社員管理";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            this.buttonEmployee.Click += new System.EventHandler(this.Member_button_Click);
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLoginName.Location = new System.Drawing.Point(1606, 36);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(0, 36);
            this.labelLoginName.TabIndex = 95;
            // 
            // F_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel1);
            this.Name = "F_menu";
            this.Text = "F_menu";
            this.Activated += new System.EventHandler(this.F_menu_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonShipment;
        private System.Windows.Forms.Button buttonChumon;
        private System.Windows.Forms.Button buttonArrival;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonSyukko;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonHattyu;
        private System.Windows.Forms.Button buttonWarehousing;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelLoginName;
    }
}