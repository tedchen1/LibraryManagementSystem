using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class login : Form
    {
        LibraryManage libraryManage = null;
        User user = null;
        public login(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
            user = libraryManage.user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //用户名历史记录改用ini记录并显示
            String[] names = libraryManage.getNameList();
            foreach (String name in names)
            {
                cb_userName.Items.Add(name);
            }
            String lastName = libraryManage.getLastName();
            if("" == lastName){
                cb_userName.SelectedIndex = 0;
            }
            else
            {
                cb_userName.Text = lastName;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ("" == cb_userName.Text)
            {
                MessageBox.Show("账号不能为空","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cb_userName.Focus();
                return;
            }
            //验证密码真的正确性
            bool ret = libraryManage.login(cb_userName.Text, tb_passWord.Text);
            if (ret && !user.isLock)
            {
                MessageBox.Show("登陆成功", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("此用户已停用或密码错误,请重新输入!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
