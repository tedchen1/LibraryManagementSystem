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
    public partial class UserManages : Form
    {
        List<User> list = null;
        LibraryManage libraryManage = null;
        public UserManages(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void UserManger_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        void UpdateView()
        {
            list = libraryManage.userManage.getUserList();
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].id.ToString();
                lvi.SubItems.Add(list[i].code);
                lvi.SubItems.Add(list[i].name);
                lvi.SubItems.Add(list[i].isLock ? "是":"否");
                lvi.SubItems.Add(list[i].userRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].bookRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].readerRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].borrowRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].logRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].bakRights != null ? "有" : "无");
                listView1.Items.Add(lvi);
            }
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd ua = new UserAdd(libraryManage);
            if(DialogResult.OK == ua.ShowDialog())
            {
                UpdateView();
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count) 
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);
            UserEdit ue = new UserEdit(list[index], libraryManage);
            if (DialogResult.OK == ue.ShowDialog())
            {
                UpdateView();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count) 
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);
            if (libraryManage.user.id == list[index].id)
            {
                MessageBox.Show("无法删除自己的账号！", "删除提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("确定删除该用户吗?\n" + "账号:" + list[index].code + "\n昵称:" + list[index].name, "删除提示", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation))
            {
                if (libraryManage.userManage.delUser(list[index]))
                {
                    MessageBox.Show("删除成功","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateView();
                }else
                {
                    MessageBox.Show("删除失败","提示" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            编辑ToolStripMenuItem_Click(sender, e);
        }

        private void 查找图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindUser fu = new FindUser();
            fu.Show(list, listView1, libraryManage);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

    }
}
