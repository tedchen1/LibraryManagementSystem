using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class EditPassword : Form
    {
        LibraryManage libraryManage = null;
        User user = null;
        public EditPassword(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
            user = libraryManage.user;
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {
            tb_UserCode.Text = user.code;
            tb_Password.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tb_NewPassword.Text == "")
            {
                MessageBox.Show("新密码不能为空", "修改提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_UserCode.Focus();
                return;
            }
            bool ret = libraryManage.userManage.checkPwd(tb_Password.Text.Trim());
            if (ret)
            {
                if (libraryManage.userManage.updatePWD(tb_NewPassword.Text.Trim()))
                {
                    MessageBox.Show("密码更新成功!", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码更新失败!", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_NewPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("密码错误,请重新输入!", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
