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
    public partial class FindReaderCate : Form
    {
        public FindReaderCate()
        {
            InitializeComponent();
        }

        ListView lv;
        LibraryManage libraryManage = null;
        List<ReaderCate> list = null;
        private void FindBook_Load(object sender, EventArgs e)
        {
            cb_LogCate.SelectedIndex = 0;
        }
        public void Show(List<ReaderCate> list, ListView lv, LibraryManage lm)
        {
            this.list = list;
            this.lv = lv;
            libraryManage = lm;
            this.Show();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateView();
        }

        void UpdateView()
        {
            list.Clear();
            String colname = MakeColName(cb_LogCate.SelectedIndex);
            List<ReaderCate> tmp = libraryManage.readerManage.findReaderCate(colname, textBox1.Text);
            foreach (ReaderCate rc in tmp)
            {
                list.Add(rc);
            }
            lv.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].Name);
                lvi.SubItems.Add(list[i].LimitBooksCount.ToString());
                lvi.SubItems.Add(list[i].LimitDays.ToString());
                lvi.SubItems.Add(list[i].ReBorrowTimes.ToString());
                lvi.SubItems.Add(list[i].ReBorrowDays.ToString());
                lv.Items.Add(lvi);
            }
        }
        
        string MakeColName(int index)
        {
            string name;
            switch(index)
            {
                case 0:
                    name = "Name";
                    break;
                default:
                    name = "Name";
                    break;
            }
            return name;
        }
    }
}
