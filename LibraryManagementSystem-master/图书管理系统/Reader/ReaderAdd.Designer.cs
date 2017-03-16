namespace 图书管理系统
{
    partial class ReaderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderAdd));
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Sex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Cate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_add = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_Code
            // 
            this.tb_Code.Location = new System.Drawing.Point(77, 20);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(187, 21);
            this.tb_Code.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "昵称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "帐号:";
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
            this.btn_Exit.Location = new System.Drawing.Point(200, 201);
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
            this.btn_Login.Location = new System.Drawing.Point(129, 201);
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
            this.label3.Location = new System.Drawing.Point(34, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "性别:";
            // 
            // cb_Sex
            // 
            this.cb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sex.FormattingEnabled = true;
            this.cb_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_Sex.Location = new System.Drawing.Point(77, 100);
            this.cb_Sex.Name = "cb_Sex";
            this.cb_Sex.Size = new System.Drawing.Size(187, 20);
            this.cb_Sex.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "手机号码:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(77, 126);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(187, 21);
            this.tb_Phone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "电子邮箱:";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(77, 153);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(187, 21);
            this.tb_Email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "用户角色:";
            // 
            // cb_Cate
            // 
            this.cb_Cate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cate.FormattingEnabled = true;
            this.cb_Cate.Location = new System.Drawing.Point(77, 74);
            this.cb_Cate.Name = "cb_Cate";
            this.cb_Cate.Size = new System.Drawing.Size(187, 20);
            this.cb_Cate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(27, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(27, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "*";
            // 
            // cb_add
            // 
            this.cb_add.AutoSize = true;
            this.cb_add.Location = new System.Drawing.Point(162, 181);
            this.cb_add.Name = "cb_add";
            this.cb_add.Size = new System.Drawing.Size(108, 16);
            this.cb_add.TabIndex = 59;
            this.cb_add.Text = "添加后继续添加";
            this.cb_add.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(78, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "借阅权限";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReaderAdd
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(271, 239);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cb_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_Cate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Sex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReaderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加读者";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Cate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_add;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}