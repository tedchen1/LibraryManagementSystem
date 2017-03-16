using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class UserAdd : Form
    {
        DialogResult m_DialogResult;
        LibraryManage libraryManage = null;
        public UserAdd(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            this.DialogResult = m_DialogResult;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_Code.Text || "" == tb_Name.Text)
            {
                MessageBox.Show("账号,昵称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Code.Focus();
                return;
            }
            User user = new User();
            user.code = tb_Code.Text;
            user.name = tb_Name.Text;
            user.isLock = IsLock.Checked;
            user.userRights = IsUser.Checked ? new UserRights(null) : null;
            user.bookRights = IsBook.Checked ? new BookRights(null) : null;
            user.readerRights = IsReader.Checked ? new ReaderRights(null) : null;
            user.borrowRights = IsBorrow.Checked ? new BorrowRights(null) : null;
            user.logRights = IsLog.Checked ? new LogRights(null) : null;
            user.bakRights = IsBak.Checked ? new BakRights(null) : null;
            if (libraryManage.userManage.addUser(user))
            {
                m_DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (true == cb_add.Checked)
                {
                    clear();
                }
                else
                {
                    this.DialogResult = m_DialogResult;
                }
            }
            else
            {
                m_DialogResult = System.Windows.Forms.DialogResult.No;
                String errorString = "";
                switch (libraryManage.conn.getErrorCode())
                {
                    //字段信息重复
                    case 19:
                        errorString = "账号重复，添加失败";
                        break;
                    default:
                        errorString = "添加失败";
                        break;
                }
                MessageBox.Show(errorString, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Code.Focus();
            }
            
        }

        void clear()
        {
            tb_Code.Text = "";
            tb_Name.Text = "";
            IsLock.Checked = false;
            IsUser.Checked= false;
            IsBook.Checked= false;
            IsReader.Checked= false;
            IsBorrow.Checked= false;
            IsLog.Checked= false;
            IsBak.Checked = false;
            tb_Code.Focus();
        }
    }
}
