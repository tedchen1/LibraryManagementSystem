namespace 图书管理系统
{
    partial class BookAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAdd));
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Publisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_BookCate = new System.Windows.Forms.TextBox();
            this.tb_PublisherDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_Price = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_KeyWords = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Language = new System.Windows.Forms.ComboBox();
            this.nup_totalcount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_add = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_totalcount)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(77, 20);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(187, 21);
            this.tb_ISBN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "图书名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "ISBN:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(77, 47);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(187, 21);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Image = global::图书管理系统.Properties.Resources.bullet_red;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(461, 155);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 33);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::图书管理系统.Properties.Resources.bullet_green;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(390, 155);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(65, 33);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "添加";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "图书分类:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "出版社:";
            // 
            // tb_Author
            // 
            this.tb_Author.Location = new System.Drawing.Point(77, 74);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(187, 21);
            this.tb_Author.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "出版日期:";
            // 
            // tb_Publisher
            // 
            this.tb_Publisher.Location = new System.Drawing.Point(77, 128);
            this.tb_Publisher.Name = "tb_Publisher";
            this.tb_Publisher.Size = new System.Drawing.Size(187, 21);
            this.tb_Publisher.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "图书作者:";
            // 
            // tb_BookCate
            // 
            this.tb_BookCate.Location = new System.Drawing.Point(77, 101);
            this.tb_BookCate.Name = "tb_BookCate";
            this.tb_BookCate.ReadOnly = true;
            this.tb_BookCate.Size = new System.Drawing.Size(187, 21);
            this.tb_BookCate.TabIndex = 3;
            // 
            // tb_PublisherDate
            // 
            this.tb_PublisherDate.Location = new System.Drawing.Point(340, 128);
            this.tb_PublisherDate.Name = "tb_PublisherDate";
            this.tb_PublisherDate.Size = new System.Drawing.Size(187, 21);
            this.tb_PublisherDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "图书价格:";
            // 
            // nud_Price
            // 
            this.nud_Price.DecimalPlaces = 2;
            this.nud_Price.Location = new System.Drawing.Point(341, 20);
            this.nud_Price.Name = "nud_Price";
            this.nud_Price.Size = new System.Drawing.Size(186, 21);
            this.nud_Price.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "关键字:";
            // 
            // tb_KeyWords
            // 
            this.tb_KeyWords.Location = new System.Drawing.Point(340, 47);
            this.tb_KeyWords.Name = "tb_KeyWords";
            this.tb_KeyWords.Size = new System.Drawing.Size(187, 21);
            this.tb_KeyWords.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 49;
            this.label9.Text = "语言:";
            // 
            // cb_Language
            // 
            this.cb_Language.FormattingEnabled = true;
            this.cb_Language.Items.AddRange(new object[] {
            "简体中文",
            "繁体中文",
            "英语"});
            this.cb_Language.Location = new System.Drawing.Point(340, 74);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.Size = new System.Drawing.Size(187, 20);
            this.cb_Language.TabIndex = 7;
            // 
            // nup_totalcount
            // 
            this.nup_totalcount.Location = new System.Drawing.Point(340, 100);
            this.nup_totalcount.Name = "nup_totalcount";
            this.nup_totalcount.Size = new System.Drawing.Size(186, 21);
            this.nup_totalcount.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 52;
            this.label10.Text = "图书数量:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(238, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 19);
            this.button1.TabIndex = 53;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(27, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 54;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(267, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 55;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(3, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 56;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(3, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 57;
            this.label14.Text = "*";
            // 
            // cb_add
            // 
            this.cb_add.AutoSize = true;
            this.cb_add.Location = new System.Drawing.Point(155, 155);
            this.cb_add.Name = "cb_add";
            this.cb_add.Size = new System.Drawing.Size(108, 16);
            this.cb_add.TabIndex = 61;
            this.cb_add.Text = "添加后继续添加";
            this.cb_add.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "能否借出";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(3, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 63;
            this.label15.Text = "*";
            // 
            // BookAdd
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(533, 193);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cb_add);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nup_totalcount);
            this.Controls.Add(this.cb_Language);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_KeyWords);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nud_Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_PublisherDate);
            this.Controls.Add(this.tb_BookCate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Publisher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加图书";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_totalcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Publisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_BookCate;
        private System.Windows.Forms.TextBox tb_PublisherDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_KeyWords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Language;
        private System.Windows.Forms.NumericUpDown nup_totalcount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cb_add;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label15;
    }
}