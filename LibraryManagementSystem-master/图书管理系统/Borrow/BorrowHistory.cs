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
    public partial class BorrowHistory : Form
    {
        LibraryManage libraryManage = null;
        public BorrowHistory(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateView()
        {
            List<Borrow> list = libraryManage.borrowManage.getBorrowList();
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].ISBN);
                lvi.SubItems.Add(list[i].BookName);
                lvi.SubItems.Add(list[i].ReaderCode);
                lvi.SubItems.Add(list[i].ReaderName);
                lvi.SubItems.Add(list[i].Date.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(list[i].ReturnDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(list[i].IsReturn ? "已返还" : "未返还");
                lvi.SubItems.Add(list[i].ReBorrowTimes.ToString());
                lvi.SubItems.Add(list[i].BorrowOperator);
                lvi.SubItems.Add(list[i].ReturnOperator);
                listView1.Items.Add(lvi);
            }
        }

        private void BorrowHistory_Load(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
