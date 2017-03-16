namespace 图书管理系统
{
    partial class BakDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakDB));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_folder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_foloder = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_bak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dbPath = new System.Windows.Forms.TextBox();
            this.btn_recover = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择数据库的备份目录:";
            // 
            // tb_folder
            // 
            this.tb_folder.Location = new System.Drawing.Point(12, 103);
            this.tb_folder.Name = "tb_folder";
            this.tb_folder.ReadOnly = true;
            this.tb_folder.Size = new System.Drawing.Size(310, 21);
            this.tb_folder.TabIndex = 1;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "请选择数据库的备份目录";
            // 
            // btn_foloder
            // 
            this.btn_foloder.Image = global::图书管理系统.Properties.Resources.folder;
            this.btn_foloder.Location = new System.Drawing.Point(328, 101);
            this.btn_foloder.Name = "btn_foloder";
            this.btn_foloder.Size = new System.Drawing.Size(25, 23);
            this.btn_foloder.TabIndex = 2;
            this.btn_foloder.UseVisualStyleBackColor = true;
            this.btn_foloder.Click += new System.EventHandler(this.btn_foloder_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Image = global::图书管理系统.Properties.Resources.bullet_red;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(288, 130);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 33);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_bak
            // 
            this.btn_bak.Image = global::图书管理系统.Properties.Resources.bullet_green;
            this.btn_bak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bak.Location = new System.Drawing.Point(217, 130);
            this.btn_bak.Name = "btn_bak";
            this.btn_bak.Size = new System.Drawing.Size(65, 33);
            this.btn_bak.TabIndex = 9;
            this.btn_bak.Text = "备份";
            this.btn_bak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bak.UseVisualStyleBackColor = true;
            this.btn_bak.Click += new System.EventHandler(this.btn_bak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "当前数据库地址:";
            // 
            // tb_dbPath
            // 
            this.tb_dbPath.Location = new System.Drawing.Point(12, 46);
            this.tb_dbPath.Name = "tb_dbPath";
            this.tb_dbPath.ReadOnly = true;
            this.tb_dbPath.Size = new System.Drawing.Size(310, 21);
            this.tb_dbPath.TabIndex = 12;
            // 
            // btn_recover
            // 
            this.btn_recover.Image = global::图书管理系统.Properties.Resources.bullet_pink;
            this.btn_recover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Location = new System.Drawing.Point(12, 130);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(65, 33);
            this.btn_recover.TabIndex = 13;
            this.btn_recover.Text = "恢复";
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recover.UseVisualStyleBackColor = true;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "db 数据备份文件|*.dbbak";
            // 
            // BakDB
            // 
            this.AcceptButton = this.btn_bak;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(361, 172);
            this.Controls.Add(this.btn_recover);
            this.Controls.Add(this.tb_dbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_bak);
            this.Controls.Add(this.btn_foloder);
            this.Controls.Add(this.tb_folder);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BakDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库备份";
            this.Load += new System.EventHandler(this.BakDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_foloder;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_bak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dbPath;
        private System.Windows.Forms.Button btn_recover;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}