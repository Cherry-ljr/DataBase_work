﻿namespace 书店管理系统
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.respository = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cus_name = new System.Windows.Forms.TextBox();
            this.Cus_Delete = new System.Windows.Forms.Button();
            this.Cus_Search = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Book_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Book_Delete = new System.Windows.Forms.Button();
            this.Book_Search = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.rep_search = new System.Windows.Forms.Button();
            this.ManagerInfo_Btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.PictureBox();
            this.respository.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // respository
            // 
            this.respository.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.respository.Controls.Add(this.tabPage1);
            this.respository.Controls.Add(this.tabPage2);
            this.respository.Controls.Add(this.tabPage3);
            this.respository.Controls.Add(this.tabPage4);
            this.respository.Location = new System.Drawing.Point(0, 30);
            this.respository.Name = "respository";
            this.respository.SelectedIndex = 0;
            this.respository.Size = new System.Drawing.Size(498, 334);
            this.respository.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.cus_name);
            this.tabPage1.Controls.Add(this.Cus_Delete);
            this.tabPage1.Controls.Add(this.Cus_Search);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "顾客管理";
            // 
            // cus_name
            // 
            this.cus_name.Location = new System.Drawing.Point(41, 18);
            this.cus_name.Name = "cus_name";
            this.cus_name.Size = new System.Drawing.Size(114, 21);
            this.cus_name.TabIndex = 3;
            // 
            // Cus_Delete
            // 
            this.Cus_Delete.Location = new System.Drawing.Point(298, 18);
            this.Cus_Delete.Name = "Cus_Delete";
            this.Cus_Delete.Size = new System.Drawing.Size(75, 23);
            this.Cus_Delete.TabIndex = 2;
            this.Cus_Delete.Text = "删除";
            this.Cus_Delete.UseVisualStyleBackColor = true;
            this.Cus_Delete.Click += new System.EventHandler(this.Cus_Delete_Click);
            // 
            // Cus_Search
            // 
            this.Cus_Search.Location = new System.Drawing.Point(161, 18);
            this.Cus_Search.Name = "Cus_Search";
            this.Cus_Search.Size = new System.Drawing.Size(75, 23);
            this.Cus_Search.TabIndex = 1;
            this.Cus_Search.Text = "查询";
            this.Cus_Search.UseVisualStyleBackColor = true;
            this.Cus_Search.Click += new System.EventHandler(this.Cus_Search_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 45);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(476, 246);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.OK);
            this.tabPage2.Controls.Add(this.Search);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "订单管理";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(481, 250);
            this.dataGridView2.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(290, 15);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "确认订单";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(66, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Snow;
            this.tabPage3.Controls.Add(this.Book_Add);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.Book_Delete);
            this.tabPage3.Controls.Add(this.Book_Search);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "书籍管理";
            // 
            // Book_Add
            // 
            this.Book_Add.Location = new System.Drawing.Point(320, 17);
            this.Book_Add.Name = "Book_Add";
            this.Book_Add.Size = new System.Drawing.Size(75, 23);
            this.Book_Add.TabIndex = 4;
            this.Book_Add.Text = "增加";
            this.Book_Add.UseVisualStyleBackColor = true;
            this.Book_Add.Click += new System.EventHandler(this.Book_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(481, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // Book_Delete
            // 
            this.Book_Delete.Location = new System.Drawing.Point(167, 17);
            this.Book_Delete.Name = "Book_Delete";
            this.Book_Delete.Size = new System.Drawing.Size(75, 23);
            this.Book_Delete.TabIndex = 2;
            this.Book_Delete.Text = "删除";
            this.Book_Delete.UseVisualStyleBackColor = true;
            this.Book_Delete.Click += new System.EventHandler(this.Book_Delete_Click);
            // 
            // Book_Search
            // 
            this.Book_Search.Location = new System.Drawing.Point(28, 17);
            this.Book_Search.Name = "Book_Search";
            this.Book_Search.Size = new System.Drawing.Size(75, 23);
            this.Book_Search.TabIndex = 1;
            this.Book_Search.Text = "查询";
            this.Book_Search.UseVisualStyleBackColor = true;
            this.Book_Search.Click += new System.EventHandler(this.Book_Search_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Snow;
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.rep_search);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(490, 308);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "库存管理";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 35);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(478, 254);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellValueChanged);
            // 
            // rep_search
            // 
            this.rep_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rep_search.Location = new System.Drawing.Point(8, 6);
            this.rep_search.Name = "rep_search";
            this.rep_search.Size = new System.Drawing.Size(75, 23);
            this.rep_search.TabIndex = 1;
            this.rep_search.Text = "查询";
            this.rep_search.UseVisualStyleBackColor = true;
            this.rep_search.Click += new System.EventHandler(this.rep_search_Click);
            // 
            // ManagerInfo_Btn
            // 
            this.ManagerInfo_Btn.BackColor = System.Drawing.Color.Transparent;
            this.ManagerInfo_Btn.Location = new System.Drawing.Point(46, 1);
            this.ManagerInfo_Btn.Name = "ManagerInfo_Btn";
            this.ManagerInfo_Btn.Size = new System.Drawing.Size(75, 23);
            this.ManagerInfo_Btn.TabIndex = 1;
            this.ManagerInfo_Btn.Text = "个人信息";
            this.ManagerInfo_Btn.UseVisualStyleBackColor = false;
            this.ManagerInfo_Btn.Click += new System.EventHandler(this.ManagerInfo_Btn_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Location = new System.Drawing.Point(4, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(26, 27);
            this.back.TabIndex = 18;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 353);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ManagerInfo_Btn);
            this.Controls.Add(this.respository);
            this.Name = "Manager";
            this.Text = "后台管理";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.respository.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl respository;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Book_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Book_Delete;
        private System.Windows.Forms.Button Book_Search;
        private System.Windows.Forms.TextBox cus_name;
        private System.Windows.Forms.Button Cus_Delete;
        private System.Windows.Forms.Button Cus_Search;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ManagerInfo_Btn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button rep_search;
        private System.Windows.Forms.PictureBox back;
    }
}