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
    public partial class BorrowManage : Form
    {
        LibraryManage libraryManage = null;
        List<Borrow> list = null;
        string Code;
        public BorrowManage(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void BorrowManage_Load(object sender, EventArgs e)
        {
            cb_Book.SelectedIndex = 0;
            cb_Reader.SelectedIndex = 0;
            UpdateView();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

        void UpdateView()
        {
            list = libraryManage.borrowManage.getBorrowList(ReturnBookColName(), tb_Book.Text, ReturnReaderColName(), tb_Reader.Text);
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].ISBN);
                lvi.SubItems.Add(list[i].BookName);
                lvi.SubItems.Add(list[i].ReaderName);
                lvi.SubItems.Add(list[i].Date.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(list[i].ReturnDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(list[i].ReBorrowTimes.ToString());
                lvi.SubItems.Add(list[i].BorrowOperator);
                if (list[i].ReturnDate < DateTime.Now)
                {
                    lvi.BackColor = System.Drawing.Color.Crimson;
                    lvi.ForeColor = Color.White;
                }
                listView1.Items.Add(lvi);
            }
        }

        string ReturnBookColName()
        {
            string BookColName;
            switch (cb_Book.SelectedIndex)
            {
                case 0:
                    BookColName = "ISBN";
                    break;
                case 1:
                    BookColName = "BookName";
                    break;
                default:
                    BookColName = "ISBN";
                    break;
            }
            return BookColName;
        }
        string ReturnReaderColName()
        {
            string ReaderColName;
            switch (cb_Reader.SelectedIndex)
            {
                case 0:
                    ReaderColName = "ReaderCode";
                    break;
                case 1:
                    ReaderColName = "ReaderName";
                    break;
                default:
                    ReaderColName = "ReaderCode";
                    break;
            }
            return ReaderColName;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count)
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);

            double Price = 0;
            ReaderCate rc = libraryManage.borrowManage.getReader(list[index].ReaderCode).Cate;

            if (list[index].ReturnDate >= DateTime.Now)
            {
                
                Price = libraryManage.getBorrowCost() * rc.Discount;
                if (DialogResult.Yes == MessageBox.Show("该借阅记录须缴纳:\n" +
                    Price.ToString() + "元" +
                    "\n才能归还!\n\n已缴纳,点\"是\"\n未缴纳,点\"否\"", "费用", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                {
                    if (libraryManage.borrowManage.returnBook(list[index]))
                    {
                        Book book = libraryManage.borrowManage.getBook(list[index].ISBN);
                        libraryManage.borrowManage.addBookCount(book);
                        MessageBox.Show("还书成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        UpdateView();
                    }
                    else
                    {
                        MessageBox.Show("还书失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                int days = new TimeSpan(DateTime.Now.Ticks - list[index].ReturnDate.Ticks).Days;
                Price = libraryManage.getBorrowCost() * rc.Discount + libraryManage.getLateFee() * days;
                if (DialogResult.Yes == MessageBox.Show("该借阅记录已超出规定还书日期!\n须缴纳:\n" +
                    Price.ToString() + "元" +
                    "\n才能归还!\n\n已缴纳,点\"是\"\n未缴纳,点\"否\"", "逾期", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                {
                    if (libraryManage.borrowManage.returnBook(list[index]))
                    {
                        Book book = libraryManage.borrowManage.getBook(list[index].ISBN);
                        libraryManage.borrowManage.addBookCount(book);
                        MessageBox.Show("还书成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        UpdateView();
                    }
                    else
                    {
                        MessageBox.Show("还书失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (1 != listView1.SelectedItems.Count)
                return;

            int index = listView1.Items.IndexOf(listView1.FocusedItem);

            if (0 < list[index].ReBorrowTimes)
            {
                if (libraryManage.borrowManage.addDays(list[index]))
                {
                    MessageBox.Show("续借成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateView();
                }
                else
                {
                    MessageBox.Show("续借失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("续借次数已用完，续借失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BorrowBook bb = new BorrowBook(libraryManage);
            bb.ShowDialog();
            UpdateView();
        }

        private void 查找借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowHistory bh = new BorrowHistory(libraryManage);
            bh.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            BorrowHelp bh = new BorrowHelp();
            bh.ShowDialog();
        }

    }
}
