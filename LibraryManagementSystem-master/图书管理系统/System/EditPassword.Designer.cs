namespace 图书管理系统
{
    partial class EditPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_UserCode = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            // 
            // tb_UserCode
            // 
            this.tb_UserCode.Location = new System.Drawing.Point(83, 17);
            this.tb_UserCode.Name = "tb_UserCode";
            this.tb_UserCode.ReadOnly = true;
            this.tb_UserCode.Size = new System.Drawing.Size(176, 21);
            this.tb_UserCode.TabIndex = 3;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(83, 49);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(176, 21);
            this.tb_Password.TabIndex = 4;
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Location = new System.Drawing.Point(83, 82);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.PasswordChar = '*';
            this.tb_NewPassword.Size = new System.Drawing.Size(176, 21);
            this.tb_NewPassword.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Image = global::图书管理系统.Properties.Resources.bullet_red;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(194, 109);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 33);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = global::图书管理系统.Properties.Resources.bullet_green;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(123, 109);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(65, 33);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "*";
            // 
            // EditPassword
            // 
            this.AcceptButton = this.btn_Edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(266, 148);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.EditPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_UserCode;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label7;
    }
}