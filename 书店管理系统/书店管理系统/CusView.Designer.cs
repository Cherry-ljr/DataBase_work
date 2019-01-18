namespace 书店管理系统
{
    partial class CusView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CusView));
            this.Home_Btn = new System.Windows.Forms.PictureBox();
            this.ShopCar_Btn = new System.Windows.Forms.PictureBox();
            this.Person_Btn = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Book_Search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Shehuikexue_Btn = new System.Windows.Forms.PictureBox();
            this.Kexuejishu_Btn = new System.Windows.Forms.PictureBox();
            this.Wenxue_Btn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderSearch_Btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Yishu_Btn = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_ShopCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopCar_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shehuikexue_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kexuejishu_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wenxue_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearch_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yishu_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home_Btn
            // 
            this.Home_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home_Btn.BackgroundImage")));
            this.Home_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home_Btn.Location = new System.Drawing.Point(93, 488);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(37, 34);
            this.Home_Btn.TabIndex = 0;
            this.Home_Btn.TabStop = false;
            this.Home_Btn.Click += new System.EventHandler(this.Home_Btn_Click);
            // 
            // ShopCar_Btn
            // 
            this.ShopCar_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShopCar_Btn.BackgroundImage")));
            this.ShopCar_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShopCar_Btn.Location = new System.Drawing.Point(205, 488);
            this.ShopCar_Btn.Name = "ShopCar_Btn";
            this.ShopCar_Btn.Size = new System.Drawing.Size(38, 34);
            this.ShopCar_Btn.TabIndex = 1;
            this.ShopCar_Btn.TabStop = false;
            this.ShopCar_Btn.Click += new System.EventHandler(this.ShopCar_Btn_Click);
            // 
            // Person_Btn
            // 
            this.Person_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Person_Btn.BackgroundImage")));
            this.Person_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Person_Btn.Location = new System.Drawing.Point(344, 488);
            this.Person_Btn.Name = "Person_Btn";
            this.Person_Btn.Size = new System.Drawing.Size(38, 34);
            this.Person_Btn.TabIndex = 2;
            this.Person_Btn.TabStop = false;
            this.Person_Btn.Click += new System.EventHandler(this.Person_Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 21);
            this.textBox1.TabIndex = 3;
            // 
            // Book_Search
            // 
            this.Book_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Book_Search.BackgroundImage")));
            this.Book_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Book_Search.FlatAppearance.BorderSize = 0;
            this.Book_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_Search.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book_Search.Location = new System.Drawing.Point(429, 52);
            this.Book_Search.Name = "Book_Search";
            this.Book_Search.Size = new System.Drawing.Size(76, 32);
            this.Book_Search.TabIndex = 4;
            this.Book_Search.Text = "查询";
            this.Book_Search.UseVisualStyleBackColor = true;
            this.Book_Search.Click += new System.EventHandler(this.Book_Search_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "书名",
            "作者",
            "出版社"});
            this.comboBox1.Location = new System.Drawing.Point(51, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "图书分类";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Shehuikexue_Btn
            // 
            this.Shehuikexue_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Shehuikexue_Btn.BackgroundImage")));
            this.Shehuikexue_Btn.Location = new System.Drawing.Point(24, 169);
            this.Shehuikexue_Btn.Name = "Shehuikexue_Btn";
            this.Shehuikexue_Btn.Size = new System.Drawing.Size(109, 32);
            this.Shehuikexue_Btn.TabIndex = 9;
            this.Shehuikexue_Btn.TabStop = false;
            this.Shehuikexue_Btn.Click += new System.EventHandler(this.Shehuikexue_Btn_Click);
            // 
            // Kexuejishu_Btn
            // 
            this.Kexuejishu_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kexuejishu_Btn.BackgroundImage")));
            this.Kexuejishu_Btn.Location = new System.Drawing.Point(22, 218);
            this.Kexuejishu_Btn.Name = "Kexuejishu_Btn";
            this.Kexuejishu_Btn.Size = new System.Drawing.Size(111, 32);
            this.Kexuejishu_Btn.TabIndex = 10;
            this.Kexuejishu_Btn.TabStop = false;
            this.Kexuejishu_Btn.Click += new System.EventHandler(this.Kexuejishu_Btn_Click);
            // 
            // Wenxue_Btn
            // 
            this.Wenxue_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wenxue_Btn.BackgroundImage")));
            this.Wenxue_Btn.Location = new System.Drawing.Point(20, 268);
            this.Wenxue_Btn.Name = "Wenxue_Btn";
            this.Wenxue_Btn.Size = new System.Drawing.Size(113, 31);
            this.Wenxue_Btn.TabIndex = 11;
            this.Wenxue_Btn.TabStop = false;
            this.Wenxue_Btn.Click += new System.EventHandler(this.Wenxue_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(341, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "个人信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(468, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "订单查询";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // OrderSearch_Btn
            // 
            this.OrderSearch_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderSearch_Btn.BackgroundImage")));
            this.OrderSearch_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderSearch_Btn.Location = new System.Drawing.Point(480, 488);
            this.OrderSearch_Btn.Name = "OrderSearch_Btn";
            this.OrderSearch_Btn.Size = new System.Drawing.Size(38, 34);
            this.OrderSearch_Btn.TabIndex = 17;
            this.OrderSearch_Btn.TabStop = false;
            this.OrderSearch_Btn.Click += new System.EventHandler(this.OrderSearch_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(90, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "首页";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(202, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "购物车";
            // 
            // Yishu_Btn
            // 
            this.Yishu_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Yishu_Btn.BackgroundImage")));
            this.Yishu_Btn.Location = new System.Drawing.Point(19, 320);
            this.Yishu_Btn.Name = "Yishu_Btn";
            this.Yishu_Btn.Size = new System.Drawing.Size(114, 31);
            this.Yishu_Btn.TabIndex = 12;
            this.Yishu_Btn.TabStop = false;
            this.Yishu_Btn.Click += new System.EventHandler(this.Yishu_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(453, 309);
            this.dataGridView1.TabIndex = 20;
            // 
            // Add_ShopCar
            // 
            this.Add_ShopCar.BackColor = System.Drawing.Color.Red;
            this.Add_ShopCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_ShopCar.BackgroundImage")));
            this.Add_ShopCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_ShopCar.FlatAppearance.BorderSize = 0;
            this.Add_ShopCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_ShopCar.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add_ShopCar.ForeColor = System.Drawing.Color.Red;
            this.Add_ShopCar.Location = new System.Drawing.Point(558, 52);
            this.Add_ShopCar.Name = "Add_ShopCar";
            this.Add_ShopCar.Size = new System.Drawing.Size(91, 32);
            this.Add_ShopCar.TabIndex = 21;
            this.Add_ShopCar.Text = "加入购物车";
            this.Add_ShopCar.UseVisualStyleBackColor = false;
            this.Add_ShopCar.Click += new System.EventHandler(this.Add_ShopCar_Click);
            // 
            // CusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 546);
            this.Controls.Add(this.Add_ShopCar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderSearch_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Yishu_Btn);
            this.Controls.Add(this.Wenxue_Btn);
            this.Controls.Add(this.Kexuejishu_Btn);
            this.Controls.Add(this.Shehuikexue_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Book_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Person_Btn);
            this.Controls.Add(this.ShopCar_Btn);
            this.Controls.Add(this.Home_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CusView";
            this.Text = "顾客界面";
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopCar_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shehuikexue_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kexuejishu_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wenxue_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearch_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yishu_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Home_Btn;
        private System.Windows.Forms.PictureBox ShopCar_Btn;
        private System.Windows.Forms.PictureBox Person_Btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Book_Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Shehuikexue_Btn;
        private System.Windows.Forms.PictureBox Kexuejishu_Btn;
        private System.Windows.Forms.PictureBox Wenxue_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox OrderSearch_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Yishu_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_ShopCar;
    }
}