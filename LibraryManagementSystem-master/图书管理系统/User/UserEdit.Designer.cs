namespace 图书管理系统
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.IsLock = new System.Windows.Forms.CheckBox();
            this.IsUser = new System.Windows.Forms.CheckBox();
            this.IsBook = new System.Windows.Forms.CheckBox();
            this.IsReader = new System.Windows.Forms.CheckBox();
            this.IsBorrow = new System.Windows.Forms.CheckBox();
            this.IsLog = new System.Windows.Forms.CheckBox();
            this.IsBak = new System.Windows.Forms.CheckBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Code
            // 
            this.tb_Code.Location = new System.Drawing.Point(50, 20);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.ReadOnly = true;
            this.tb_Code.Size = new System.Drawing.Size(187, 21);
            this.tb_Code.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "昵称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "帐号:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(50, 47);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(187, 21);
            this.tb_Name.TabIndex = 25;
            // 
            // IsLock
            // 
            this.IsLock.AutoSize = true;
            this.IsLock.Location = new System.Drawing.Point(50, 82);
            this.IsLock.Name = "IsLock";
            this.IsLock.Size = new System.Drawing.Size(48, 16);
            this.IsLock.TabIndex = 26;
            this.IsLock.Text = "锁定";
            this.IsLock.UseVisualStyleBackColor = true;
            // 
            // IsUser
            // 
            this.IsUser.AutoSize = true;
            this.IsUser.Location = new System.Drawing.Point(151, 82);
            this.IsUser.Name = "IsUser";
            this.IsUser.Size = new System.Drawing.Size(72, 16);
            this.IsUser.TabIndex = 27;
            this.IsUser.Text = "用户权限";
            this.IsUser.UseVisualStyleBackColor = true;
            // 
            // IsBook
            // 
            this.IsBook.AutoSize = true;
            this.IsBook.Location = new System.Drawing.Point(50, 104);
            this.IsBook.Name = "IsBook";
            this.IsBook.Size = new System.Drawing.Size(72, 16);
            this.IsBook.TabIndex = 28;
            this.IsBook.Text = "图书权限";
            this.IsBook.UseVisualStyleBackColor = true;
            // 
            // IsReader
            // 
            this.IsReader.AutoSize = true;
            this.IsReader.Location = new System.Drawing.Point(151, 104);
            this.IsReader.Name = "IsReader";
            this.IsReader.Size = new System.Drawing.Size(72, 16);
            this.IsReader.TabIndex = 29;
            this.IsReader.Text = "读者权限";
            this.IsReader.UseVisualStyleBackColor = true;
            // 
            // IsBorrow
            // 
            this.IsBorrow.AutoSize = true;
            this.IsBorrow.Location = new System.Drawing.Point(50, 126);
            this.IsBorrow.Name = "IsBorrow";
            this.IsBorrow.Size = new System.Drawing.Size(96, 16);
            this.IsBorrow.TabIndex = 30;
            this.IsBorrow.Text = "借阅还书权限";
            this.IsBorrow.UseVisualStyleBackColor = true;
            // 
            // IsLog
            // 
            this.IsLog.AutoSize = true;
            this.IsLog.Location = new System.Drawing.Point(151, 126);
            this.IsLog.Name = "IsLog";
            this.IsLog.Size = new System.Drawing.Size(72, 16);
            this.IsLog.TabIndex = 31;
            this.IsLog.Text = "日志权限";
            this.IsLog.UseVisualStyleBackColor = true;
            // 
            // IsBak
            // 
            this.IsBak.AutoSize = true;
            this.IsBak.Location = new System.Drawing.Point(50, 148);
            this.IsBak.Name = "IsBak";
            this.IsBak.Size = new System.Drawing.Size(72, 16);
            this.IsBak.TabIndex = 32;
            this.IsBak.Text = "备份权限";
            this.IsBak.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Image = global::图书管理系统.Properties.Resources.bullet_red;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(172, 170);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 33);
            this.btn_Exit.TabIndex = 34;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::图书管理系统.Properties.Resources.bullet_green;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(101, 170);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(65, 33);
            this.btn_Login.TabIndex = 33;
            this.btn_Login.Text = "编辑";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // UserEdit
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(245, 208);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.IsBak);
            this.Controls.Add(this.IsLog);
            this.Controls.Add(this.IsBorrow);
            this.Controls.Add(this.IsReader);
            this.Controls.Add(this.IsBook);
            this.Controls.Add(this.IsUser);
            this.Controls.Add(this.IsLock);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑用户";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.CheckBox IsLock;
        private System.Windows.Forms.CheckBox IsUser;
        private System.Windows.Forms.CheckBox IsBook;
        private System.Windows.Forms.CheckBox IsReader;
        private System.Windows.Forms.CheckBox IsBorrow;
        private System.Windows.Forms.CheckBox IsLog;
        private System.Windows.Forms.CheckBox IsBak;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
    }
}