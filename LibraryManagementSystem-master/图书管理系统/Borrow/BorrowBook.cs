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
    public partial class BorrowBook : Form
    {
        LibraryManage libraryManage = null;
        Book book = null;
        Reader reader = null;
        DialogResult m_DialogResult;
        public BorrowBook(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = m_DialogResult;
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            this.m_DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book = libraryManage.borrowManage.getBook(tb_ISBN.Text);
            if(null !=book)
            {
                if (book.IsBorrow)
                {
                    if(libraryManage.borrowManage.getBookCount(book) > 0)
                    {
                        tb_BookName.Text = book.Name;
                        tb_BookAuhtor.Text = book.Author;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("该图书已被借完", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }else
                {
                    MessageBox.Show("该图书不可借阅", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("该图书不存在，请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //失败后设置为null
            book = null;
            tb_ISBN.Text = "";
            tb_BookName.Text = "";
            tb_BookAuhtor.Text = "";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(null != book && null != reader)
            {
                    if(libraryManage.borrowManage.addBorrow(book, reader))
                    {
                        libraryManage.borrowManage.subBookCount(book);
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        if(cb_add.Checked)
                        {
                            clear();
                        }else
                        {
                            this.m_DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            else
            {
                MessageBox.Show("请先选择图书和读者", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader = libraryManage.borrowManage.getReader(tb_ReaderCode.Text);

            if (null != reader)
            {
                if (reader.IsBorrow)
                {
                    int readerBorrowCount = libraryManage.borrowManage.getReaderBorrowCount(reader);
                    int borrowCount = reader.Cate.LimitBooksCount;
                    if (readerBorrowCount<borrowCount)
                    {
                        tb_ReaderName.Text = reader.Name;
                        tb_ReaderCate.Text = reader.Cate.Name;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("该读者已超过最大借阅图书数量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("该读者不可借阅图书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("该读者不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            reader = null;
            tb_ReaderCode.Text = "";
            tb_ReaderCate.Text = "";
            tb_ReaderName.Text = "";
        }

        void clear()
        {
            tb_ISBN.Text = "";
            tb_BookName.Text = "";
            tb_BookAuhtor.Text = "";
            tb_ReaderCode.Text = "";
            tb_ReaderCate.Text = "";
            tb_ReaderName.Text = "";
        }
    }
}
