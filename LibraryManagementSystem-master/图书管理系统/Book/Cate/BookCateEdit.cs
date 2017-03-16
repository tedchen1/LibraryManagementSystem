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
    public partial class BookCateEdit : Form
    {
        LibraryManage libraryManage = null;
        BookCate bookCate = null;
        BookCate parentBookCate = null;
        DialogResult m_DialogResult;
        public BookCateEdit(BookCate bc, LibraryManage lm)
        {
            InitializeComponent();
            bookCate = bc;
            libraryManage = lm;
            parentBookCate = libraryManage.bookManage.getBookCate(bookCate.ParentId);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = m_DialogResult;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            m_DialogResult = System.Windows.Forms.DialogResult.No;
            tb_BookCate.Text = libraryManage.bookManage.getFullPath(parentBookCate);
            tb_BookCate.Tag = parentBookCate.Id;
            tb_Cate.Text = bookCate.Name;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_Cate.Text)
            {
                MessageBox.Show("关键项不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_Cate.Focus();
                return;
            }

            if (null == tb_BookCate.Tag)
            {
                MessageBox.Show("父类别不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_Cate.Focus();
                return;
            }
            if (parentBookCate.Id == bookCate.Id)
            {
                MessageBox.Show("父类别不能为自己!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_Cate.Focus();
                return;
            }


            BookCate tmp = new BookCate();
            tmp.Id = bookCate.Id;
            tmp.Name = tb_Cate.Text;
            tmp.ParentId = parentBookCate.Id;

            if (libraryManage.bookManage.upBookCate(tmp))
            {
                m_DialogResult = System.Windows.Forms.DialogResult.OK;
                if (parentBookCate.Id != bookCate.ParentId)
                {
                    String path = libraryManage.bookManage.getFullPath(tmp);
                    libraryManage.bookManage.upBookFullBookCate(tmp.Id, path);
                }
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = m_DialogResult;
            }
            else
            {
                m_DialogResult = System.Windows.Forms.DialogResult.No;
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = m_DialogResult;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectBookCate sbc = new SelectBookCate(libraryManage);
            Point p = tb_BookCate.Location;
            p.Y += tb_BookCate.Height;
            sbc.Location = this.PointToScreen(p);
            sbc.Show(tb_BookCate,parentBookCate);
        }
    }
}
