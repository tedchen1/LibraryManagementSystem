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

    public partial class SelectBookCate : Form
    {
        TextBox tb;
        LibraryManage libraryManage = null;
        int Id = 0;
        BookCate bookCate = null;
        public SelectBookCate(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void SelectBookCate_Load(object sender, EventArgs e)
        {
            MakeTree(treeView1.Nodes[0].Nodes, 0);
            treeView1.Nodes[0].Expand();
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

        private void SelectBookCate_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.Close();
        }
        public void Show(TextBox tb,BookCate bc)
        {
            this.tb = tb;
            bookCate = bc;
            this.Show();
            return;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ("图书分类" == e.Node.Text)
            {
                tb.Text = "";
                Id = 0;
            }
            else
            {
                String path = e.Node.FullPath;
                path = path.Substring(path.IndexOf("\\")+1);
                tb.Text = path;
                TreeNode tn = e.Node;
                String pathId = "";
                while (null != tn && "图书分类" != tn.Text)
                {
                    //加[]是为了方便正则匹配
                    pathId = pathId.Insert(0, "[" + tn.Tag.ToString() + "]");
                    tn = tn.Parent;
                }
                tb.Tag = pathId;
                Id = Convert.ToInt32(e.Node.Tag);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void SelectBookCate_FormClosing(object sender, FormClosingEventArgs e)
        {
            BookCate bc = libraryManage.bookManage.getBookCate(Id);
            bookCate.Id = bc.Id;
            bookCate.Name = bc.Name;
            bookCate.ParentId = bc.ParentId;
        }
    }
}
