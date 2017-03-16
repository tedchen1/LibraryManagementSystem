namespace 图书管理系统
{
    partial class ReaderCateAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderCateAdd));
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n_BookCnt = new System.Windows.Forms.NumericUpDown();
            this.n_Bd = new System.Windows.Forms.NumericUpDown();
            this.n_Rt = new System.Windows.Forms.NumericUpDown();
            this.n_Rd = new System.Windows.Forms.NumericUpDown();
            this.cb_add = new System.Windows.Forms.CheckBox();
            this.n_Discount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_BookCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Rt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Rd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Discount)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(83, 14);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(120, 21);
            this.tb_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "角色名称:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Image = global::图书管理系统.Properties.Resources.bullet_red;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(138, 194);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 33);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::图书管理系统.Properties.Resources.bullet_green;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(68, 194);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(65, 33);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "添加";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "可借图书数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "可借天数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "可续借次数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "可续借天数:";
            // 
            // n_BookCnt
            // 
            this.n_BookCnt.Location = new System.Drawing.Point(83, 41);
            this.n_BookCnt.Name = "n_BookCnt";
            this.n_BookCnt.Size = new System.Drawing.Size(120, 21);
            this.n_BookCnt.TabIndex = 1;
            this.n_BookCnt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // n_Bd
            // 
            this.n_Bd.Location = new System.Drawing.Point(83, 68);
            this.n_Bd.Name = "n_Bd";
            this.n_Bd.Size = new System.Drawing.Size(120, 21);
            this.n_Bd.TabIndex = 39;
            this.n_Bd.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // n_Rt
            // 
            this.n_Rt.Location = new System.Drawing.Point(83, 95);
            this.n_Rt.Name = "n_Rt";
            this.n_Rt.Size = new System.Drawing.Size(120, 21);
            this.n_Rt.TabIndex = 40;
            this.n_Rt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // n_Rd
            // 
            this.n_Rd.Location = new System.Drawing.Point(83, 122);
            this.n_Rd.Name = "n_Rd";
            this.n_Rd.Size = new System.Drawing.Size(120, 21);
            this.n_Rd.TabIndex = 41;
            this.n_Rd.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cb_add
            // 
            this.cb_add.AutoSize = true;
            this.cb_add.Location = new System.Drawing.Point(95, 172);
            this.cb_add.Name = "cb_add";
            this.cb_add.Size = new System.Drawing.Size(108, 16);
            this.cb_add.TabIndex = 60;
            this.cb_add.Text = "添加后继续添加";
            this.cb_add.UseVisualStyleBackColor = true;
            // 
            // n_Discount
            // 
            this.n_Discount.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.n_Discount.Location = new System.Drawing.Point(83, 149);
            this.n_Discount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_Discount.Name = "n_Discount";
            this.n_Discount.Size = new System.Drawing.Size(120, 21);
            this.n_Discount.TabIndex = 62;
            this.n_Discount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 61;
            this.label6.Text = "折扣:";
            // 
            // ReaderCateAdd
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(210, 235);
            this.Controls.Add(this.n_Discount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.n_Rd);
            this.Controls.Add(this.n_Rt);
            this.Controls.Add(this.n_Bd);
            this.Controls.Add(this.n_BookCnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReaderCateAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加读者角色";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_BookCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Rt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Rd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown n_BookCnt;
        private System.Windows.Forms.NumericUpDown n_Bd;
        private System.Windows.Forms.NumericUpDown n_Rt;
        private System.Windows.Forms.NumericUpDown n_Rd;
        private System.Windows.Forms.CheckBox cb_add;
        private System.Windows.Forms.NumericUpDown n_Discount;
        private System.Windows.Forms.Label label6;
    }
}