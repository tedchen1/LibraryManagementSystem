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
    public partial class ReaderManage : Form
    {
        List<Reader> list = null;
        LibraryManage libraryManage = null;
        public ReaderManage(LibraryManage lm)
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
            list = libraryManage.readerManage.getReaderList();
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].Code);
                lvi.SubItems.Add(list[i].Name);
                lvi.SubItems.Add(list[i].Sex);
                lvi.SubItems.Add(list[i].Phone);
                lvi.SubItems.Add(list[i].Email);
                lvi.SubItems.Add(list[i].RegDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(list[i].Cate.Name);
                lvi.SubItems.Add(list[i].IsBorrow ? "是" : "否");
                listView1.Items.Add(lvi);
            }
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderAdd ra = new ReaderAdd(libraryManage);
            if(DialogResult.OK == ra.ShowDialog())
            {
                UpdateView();
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count)
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);
            ReaderEdit ue = new ReaderEdit(list[index], libraryManage);
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
            int count = libraryManage.readerManage.getReaderBorrowCount(list[index]);
            if (count > 0)
            {
                MessageBox.Show("该读者还有未完成的借阅记录,不能删除","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("确定删除该用户吗?", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (libraryManage.readerManage.delReader(list[index]))
                {
                    MessageBox.Show("删除成功","提示" ,MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateView();
                }else
                {
                    MessageBox.Show("删除失败", "提示" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void 查找图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindReader fu = new FindReader();
            fu.Show(list, listView1, libraryManage);
        }

    }
}
