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
    public partial class BookEdit : Form
    {
        LibraryManage libraryManage = null;
        Book book = null;
        BookCate bookCate = new BookCate();
        DialogResult m_DialogResult;
        public BookEdit(Book b, LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
            book = b;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = m_DialogResult;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            m_DialogResult = System.Windows.Forms.DialogResult.No;
            tb_ISBN.Text = book.ISBN;
            tb_Name.Text = book.Name;
            tb_Author.Text = book.Author;
            tb_Publisher.Text = book.Publisher;
            tb_PublisherDate.Text = book.PublishDate;
            nud_Price.Value = Convert.ToDecimal(book.Price);
            tb_KeyWords.Text = book.KeyWords;
            cb_Language.Text = book.Language;
            nup_totalcount.Value = book.TotalCount;
            tb_BookCate.Text = libraryManage.bookManage.getFullPath(book.bookCate);
            tb_BookCate.Tag = book.FullBookCate;
            cb_add.Checked = book.IsBorrow;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_ISBN.Text || "" == tb_Name.Text || "" == tb_Author.Text )
            {
                MessageBox.Show("关键项不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                nup_totalcount.Focus();
                return;
            }


            String full = tb_BookCate.Text;
            Book b = new Book();
            b.Id = book.Id;
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
            b.FullBookCate = tb_BookCate.Tag.ToString();
            b.IsBorrow = cb_add.Checked;

            if (libraryManage.bookManage.upBook(b))
            {
                m_DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("编辑成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.DialogResult = m_DialogResult;
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
                this.DialogResult = m_DialogResult;
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
        }
    }
}
