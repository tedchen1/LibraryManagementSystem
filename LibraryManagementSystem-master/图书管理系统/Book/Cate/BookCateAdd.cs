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
    public partial class BookCateAdd : Form
    {
        LibraryManage libraryManage = null;
        BookCate bookCate = null;
        BookCate parentBookCate = null;
        DialogResult m_DialogResult;
        public BookCateAdd(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = m_DialogResult;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            m_DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if ("" == tb_Cate.Text)
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

            bookCate = new BookCate();
            bookCate.Name = tb_Cate.Text;
            bookCate.ParentId = parentBookCate.Id;

            if (libraryManage.bookManage.addBookCate(bookCate))
            {
                m_DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if(true == cb_add.Checked)
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
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (false == cb_add.Checked)
                {
                    this.DialogResult = m_DialogResult;
                }
                tb_Cate.Focus();
            }
            
        }

        void clear()
        {
            tb_Cate.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectBookCate sbc = new SelectBookCate(libraryManage);
            Point p = tb_BookCate.Location;
            p.Y += tb_BookCate.Height;
            sbc.Location = this.PointToScreen(p);
            sbc.Show(tb_BookCate, parentBookCate);
        }
    }
}
