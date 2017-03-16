namespace 图书管理系统
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.cb_add = new System.Windows.Forms.CheckBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_BookAuhtor = new System.Windows.Forms.TextBox();
            this.tb_BookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ReaderCate = new System.Windows.Forms.TextBox();
            this.tb_ReaderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_ReaderCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_add
            // 
            this.cb_add.AutoSize = true;
            this.cb_add.Location = new System.Drawing.Point(12, 131);
            this.cb_add.Name = "cb_add";
            this.cb_add.Size = new System.Drawing.Size(108, 16);
            this.cb_add.TabIndex = 65;
            this.cb_add.Text = "添加后继续添加";
            this.cb_add.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Image = global::图书管理系统.Properties.Resources.bullet_red;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(509, 131);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 33);
            this.btn_Exit.TabIndex = 64;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::图书管理系统.Properties.Resources.bullet_green;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(440, 131);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(65, 33);
            this.btn_Login.TabIndex = 63;
            this.btn_Login.Text = "添加";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_BookAuhtor);
            this.groupBox1.Controls.Add(this.tb_BookName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_ISBN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 113);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // tb_BookAuhtor
            // 
            this.tb_BookAuhtor.Location = new System.Drawing.Point(61, 81);
            this.tb_BookAuhtor.Name = "tb_BookAuhtor";
            this.tb_BookAuhtor.ReadOnly = true;
            this.tb_BookAuhtor.Size = new System.Drawing.Size(148, 21);
            this.tb_BookAuhtor.TabIndex = 6;
            // 
            // tb_BookName
            // 
            this.tb_BookName.Location = new System.Drawing.Point(61, 54);
            this.tb_BookName.Name = "tb_BookName";
            this.tb_BookName.ReadOnly = true;
            this.tb_BookName.Size = new System.Drawing.Size(148, 21);
            this.tb_BookName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "图书作者:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图书名称:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择图书";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(61, 20);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(148, 21);
            this.tb_ISBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ReaderCate);
            this.groupBox2.Controls.Add(this.tb_ReaderName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tb_ReaderCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 113);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息";
            // 
            // tb_ReaderCate
            // 
            this.tb_ReaderCate.Location = new System.Drawing.Point(63, 81);
            this.tb_ReaderCate.Name = "tb_ReaderCate";
            this.tb_ReaderCate.ReadOnly = true;
            this.tb_ReaderCate.Size = new System.Drawing.Size(148, 21);
            this.tb_ReaderCate.TabIndex = 13;
            // 
            // tb_ReaderName
            // 
            this.tb_ReaderName.Location = new System.Drawing.Point(63, 54);
            this.tb_ReaderName.Name = "tb_ReaderName";
            this.tb_ReaderName.ReadOnly = true;
            this.tb_ReaderName.Size = new System.Drawing.Size(148, 21);
            this.tb_ReaderName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "读者角色:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "读者名称:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "选择读者";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_ReaderCode
            // 
            this.tb_ReaderCode.Location = new System.Drawing.Point(63, 20);
            this.tb_ReaderCode.Name = "tb_ReaderCode";
            this.tb_ReaderCode.Size = new System.Drawing.Size(148, 21);
            this.tb_ReaderCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "读者账号:";
            // 
            // BorrowBook
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(580, 170);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_add);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借阅图书";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_add;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_BookAuhtor;
        private System.Windows.Forms.TextBox tb_BookName;
        private System.Windows.Forms.TextBox tb_ReaderCate;
        private System.Windows.Forms.TextBox tb_ReaderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_ReaderCode;
        private System.Windows.Forms.Label label6;

    }
}