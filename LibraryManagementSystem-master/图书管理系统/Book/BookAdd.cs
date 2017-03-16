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
    //这里是通过文本框的Tag属性来传递图书类别Id的
    public partial class BookAdd : Form
    {
        LibraryManage libraryManage = null;
        BookCate bookCate = new BookCate();
        DialogResult m_DialogResult;
        public BookAdd(LibraryManage lm)
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
            if("" == tb_ISBN.Text || "" == tb_Name.Text || "" == tb_Author.Text )
            {
                MessageBox.Show("关键项不能为空!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                tb_ISBN.Focus();
                return;
            }
            if(0 ==nup_totalcount.Value)
            {
                MessageBox.Show("图书数量不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                nup_totalcount.Focus();
                return;
            }
            if (0 == bookCate.Id && null == tb_BookCate.Tag)
            {
                MessageBox.Show("图书分类不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            String full = tb_BookCate.Tag.ToString();
            Book b = new Book();
            b.Id = 0;
            b.ISBN = tb_ISBN.Text;
            b.Name = tb_Name.Text;
            b.Author = tb_Author.Text;
            b.bookCate = bookCate;
            b.Publisher = tb_Publisher.Text;
            b.PublishDate = tb_PublisherDate.Text;
            b.Price = nud_Price.Value;
            b.KeyWords = tb_KeyWords.Text;
            b.Language = cb_Language.Text;
            b.TotalCount = nup_totalcount.Value;
            b.Operator = libraryManage.user;
            b.FullBookCate = full;
            b.IsBorrow = checkBox1.Checked;

            if (libraryManage.bookManage.addBook(b))
            {
                m_DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("添加成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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
                String errorString = "";
                switch (libraryManage.conn.getErrorCode())
                {
                    //字段信息重复
                    case 19:
                        errorString = "ISBN重复，添加失败";
                        break;
                    default:
                        errorString = "添加失败";
                        break;
                }
                MessageBox.Show(errorString, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ISBN.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectBookCate sbc = new SelectBookCate(libraryManage);
            Point p = tb_BookCate.Location;
            p.Y += tb_BookCate.Height;
            sbc.Location = this.PointToScreen(p);
            sbc.Show(tb_BookCate, bookCate);
        }

        void clear()
        {
            tb_ISBN.Text = "";
            tb_Name.Text = "";
            tb_Author.Text = "";
            tb_BookCate.Text = "";
            tb_Publisher.Text = "";
            tb_PublisherDate.Text = "";
            tb_KeyWords.Text = "";
            cb_Language.Text = "";
            nud_Price.Value = 0;
            nup_totalcount.Value = 0;
            tb_ISBN.Focus();
            tb_BookCate.Tag = null; 
            bookCate = null;
        }
    }
}
