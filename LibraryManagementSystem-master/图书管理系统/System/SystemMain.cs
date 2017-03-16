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
    public partial class SystemMain : Form
    {
        LibraryManage libraryManage = null;
        User user = null;
        public SystemMain(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
            user = lm.user;
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SystemMain_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "    - 当前用户: " + user.code;
            toolStripStatusLabel1.Text  = "当前用户:" + user.code;
            toolStripStatusLabel2.Text = "图书总数:" + libraryManage.getBookCount().ToString() + " 本";
            toolStripStatusLabel3.Text = "读者人数:" + libraryManage.getReaderCount().ToString() + " 人";
            toolStripStatusLabel4.Text = "借阅记录:" + libraryManage.getBorrowCount().ToString() + " 条";
        }

        private void SystemMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void 系统参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 系统设置sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.bakRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BakDB bak = new BakDB(libraryManage);
            bak.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPassword ep = new EditPassword(libraryManage);
            ep.ShowDialog();
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void 借阅还书续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.borrowRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BorrowManage bm = new BorrowManage(libraryManage);
            bm.ShowDialog();
        }

        private void 图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.bookRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BookManage bm = new BookManage(libraryManage);
            bm.ShowDialog();
        }

        private void 读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.readerRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReaderManage rm = new ReaderManage(libraryManage);
            rm.ShowDialog();

        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (null == user.userRights)
            {
                MessageBox.Show("权限不足","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            UserManages um = new UserManages(libraryManage);
            um.ShowDialog();
        }

        private void 查看日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.logRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LogShow ls = new LogShow(libraryManage);
            ls.ShowDialog();
        }

        private void 读者类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.readerRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ReaderCateManage rcm = new ReaderCateManage(libraryManage);
            rcm.ShowDialog();

        }

        private void 书刊类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == user.bookRights)
            {
                MessageBox.Show("权限不足", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BookCateManage bcm = new BookCateManage(libraryManage);
            bcm.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSetting ss = new SystemSetting(libraryManage);
            ss.ShowDialog();
        }
    }
}
