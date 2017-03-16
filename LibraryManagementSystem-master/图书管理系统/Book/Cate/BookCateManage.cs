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
    public partial class BookCateManage : Form
    {
        LibraryManage libraryManage = null;
        List<BookCate> list = null;
        int ParentId = 0;
        public BookCateManage(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void LogShow_Load(object sender, EventArgs e)
        {
            MakeTree(treeView1.Nodes[0].Nodes,0);
            treeView1.Nodes[0].Expand();
            UpdateView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            编辑ToolStripMenuItem_Click(sender, e);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查找图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBook fb = new FindBook();
            fb.Show(listView1);
        }

        void MakeTree(TreeNodeCollection tnc, int Id = 0)
        {
            List<BookCate> list = libraryManage.bookManage.getBookCateList(Id);
            if (0 != list.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    tnc.Add(list[i].Name);
                    tnc[tnc.Count - 1].Tag = list[i].Id;
                    MakeTree(tnc[tnc.Count - 1].Nodes, list[i].Id);
                }
            }
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ("图书分类" == e.Node.Text)
            {
                ParentId = 0;
            }
            else
            {
                ParentId = Convert.ToInt32(e.Node.Tag);
            }
            UpdateView(ParentId);
        }
        void UpdateView(int ParentId = 0)
        {
            list = libraryManage.bookManage.getBookCateList(ParentId);
            listView1.Items.Clear();
            for(int i =0;i<list.Count;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].Name);
                listView1.Items.Add(lvi);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (0 == listView1.SelectedItems.Count) return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);

            int count = libraryManage.bookManage.getBookCateChildCount(list[index].Id);
            if(count > 0){
                MessageBox.Show("该类别下还有子类，不能删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            count = libraryManage.bookManage.getBookCateBookCount(list[index].Id);
            if (count > 0)
            {
                MessageBox.Show("还有属于该类别的图书，不能删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("确定删除该图书类别吗?", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                if (libraryManage.bookManage.delBookCate(list[index]))
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateView(ParentId);
                    MakeTree(treeView1.Nodes[0].Nodes, 0);
                    treeView1.Nodes[0].Expand();
                    UpdateView();
                }
                else
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (0 == listView1.SelectedItems.Count) return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);

            BookCateEdit ba = new BookCateEdit(list[index], libraryManage);
            if (DialogResult.OK == ba.ShowDialog())
            {
                UpdateView(ParentId);
                if (0 != ParentId)
                {
                    treeView1.SelectedNode.Nodes.Clear();
                    MakeTree(treeView1.SelectedNode.Nodes, ParentId);
                }
                else
                {
                    treeView1.Nodes[0].Nodes.Clear();
                    MakeTree(treeView1.Nodes[0].Nodes, 0);
                    treeView1.Nodes[0].Expand();
                }
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            BookCateAdd ba = new BookCateAdd(libraryManage);
            if (DialogResult.OK == ba.ShowDialog())
            {
                UpdateView(ParentId);
                if (0 != ParentId)
                {
                    treeView1.SelectedNode.Nodes.Clear();
                    MakeTree(treeView1.SelectedNode.Nodes, ParentId);
                }
                else
                {
                    treeView1.Nodes[0].Nodes.Clear();
                    MakeTree(treeView1.Nodes[0].Nodes, 0);
                    treeView1.Nodes[0].Expand();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateView(ParentId);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateView(ParentId);
        }

        private void 查找图书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FindBookCate fbc = new FindBookCate();
            fbc.Show(list, listView1, libraryManage);
        }
    }
}
