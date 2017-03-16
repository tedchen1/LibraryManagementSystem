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
    public partial class FindBookCate : Form
    {
        public FindBookCate()
        {
            InitializeComponent();
        }

        ListView lv;
        LibraryManage libraryManage = null;
        List<BookCate> list = null;
        private void FindBook_Load(object sender, EventArgs e)
        {
            cb_LogCate.SelectedIndex = 0;
        }
        public void Show(List<BookCate> list, ListView lv, LibraryManage lm)
        {
            this.lv = lv;
            this.list = list;
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
            //String colname = MakeColName(cb_LogCate.SelectedIndex);
            list.Clear();
            List<BookCate> tmp = libraryManage.bookManage.getBookCateList(textBox1.Text); ;
            foreach(BookCate bc in tmp)
            {
                //直接赋值不能修改外层的变量中的值
                list.Add(bc);
            }
            lv.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].Name);
                lv.Items.Add(lvi);
            }
        }
        
        /*
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
        }*/
    }
}
