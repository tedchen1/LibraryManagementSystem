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
    public partial class UserEdit : Form
    {
        //被编辑的用户类
        LibraryManage libraryManage = null;
        User user = null;
        public UserEdit(User u, LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
            user = u;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            tb_Code.Text = user.code;
            tb_Name.Text = user.name;
            IsLock.Checked = user.isLock;
            IsUser.Checked = user.userRights != null ? true : false;
            IsBook.Checked = user.bookRights != null ? true : false;
            IsReader.Checked = user.readerRights != null ? true : false;
            IsBorrow.Checked = user.borrowRights != null ? true : false;
            IsLog.Checked = user.logRights != null ? true : false;
            IsBak.Checked = user.bakRights != null ? true : false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_Name.Text)
            {
                MessageBox.Show("昵称不能为空","提示", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                tb_Code.Focus();
                return;
            }

            //防止修改原来的信息
            User user = new User();
            user.id = this.user.id;
            user.code = this.user.code;
            user.name = tb_Name.Text;
            user.isLock = IsLock.Checked;
            user.userRights = IsUser.Checked ? new UserRights(null) : null;
            user.bookRights = IsBook.Checked ? new BookRights(null) : null;
            user.readerRights = IsReader.Checked ? new ReaderRights(null) : null;
            user.borrowRights = IsBorrow.Checked ? new BorrowRights(null) : null;
            user.logRights = IsLog.Checked ? new LogRights(null) : null;
            user.bakRights = IsBak.Checked ? new BakRights(null) : null;

            if (libraryManage.userManage.upUser(user))
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
            
        }
    }
}
