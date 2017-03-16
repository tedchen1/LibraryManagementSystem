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
    public partial class BookManage : Form
    {
        LibraryManage libraryManage = null;
        List<Book> list = null;
        public BookManage(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void LogShow_Load(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Nodes.Clear();
            MakeTree(treeView1.Nodes[0].Nodes, 0);
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
            fb.Show(list, listView1,libraryManage);
        }

        void MakeTree(TreeNodeCollection tnc,int Id=0)
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
            if("图书分类" == e.Node.Text)
            {
                UpdateView();
            }
            else
            {
                UpdateView(e.Node.Tag.ToString());
            }
        }
        void UpdateView(String CateId = ".")
        {
            list = libraryManage.bookManage.getBookListForREGEXP(CateId);
            listView1.Items.Clear();
            for(int i =0;i<list.Count;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].ISBN);
                lvi.SubItems.Add(list[i].Name);
                lvi.SubItems.Add(list[i].Author);
                lvi.SubItems.Add(list[i].bookCate.Name);
                lvi.SubItems.Add(list[i].Publisher);
                lvi.SubItems.Add(list[i].PublishDate);
                lvi.SubItems.Add(list[i].Price.ToString());
                lvi.SubItems.Add(list[i].KeyWords);
                lvi.SubItems.Add(list[i].Language);
                lvi.SubItems.Add(list[i].TotalCount.ToString());
                lvi.SubItems.Add(list[i].Operator.name);
                lvi.SubItems.Add(list[i].IsBorrow? "是" : "否");
                listView1.Items.Add(lvi);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count)
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);
            int count = libraryManage.bookManage.getBookBorrowCount(list[index].Id);
            if(count>0)
            {
                MessageBox.Show("该图书还有未完成的借阅记录,不能删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("确定删除该图书吗?", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                if (libraryManage.bookManage.delBook(list[index]))
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if(null != treeView1.SelectedNode)
                    {
                        UpdateView(treeView1.SelectedNode.Text);
                    }else
                    {
                        UpdateView();
                    }
                    
                }
                else
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count)
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);
            BookEdit ba = new BookEdit(list[index], libraryManage);
            if (DialogResult.OK == ba.ShowDialog())
            {
                if (null != treeView1.SelectedNode)
                {
                    UpdateView(treeView1.SelectedNode.Tag.ToString());
                }
                else
                {
                    UpdateView();
                }
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAdd ba = new BookAdd(libraryManage);
            if (DialogResult.OK ==ba.ShowDialog())
            {
                UpdateView();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == treeView1.SelectedNode)
            {
                UpdateView();
            }
            else if ("图书分类" == treeView1.SelectedNode.Text)
            {
                UpdateView();
            }
            else
            {
                UpdateView(treeView1.SelectedNode.Tag.ToString());
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
