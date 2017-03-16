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
    public partial class FindBook : Form
    {
        public FindBook()
        {
            InitializeComponent();
        }

        ListView lv;
        LibraryManage libraryManage = null;
        List<Book> list = null;
        private void FindBook_Load(object sender, EventArgs e)
        {
            cb_LogCate.SelectedIndex = 0;
        }
        public void Show(List<Book> list, ListView lv, LibraryManage lm)
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
            String colname = MakeColName(cb_LogCate.SelectedIndex);
            list.Clear();
            List<Book> tmp = libraryManage.bookManage.getBookList(colname, textBox1.Text);
            foreach (Book b in tmp)
            {
                //直接赋值不能修改外层的变量中的值
                list.Add(b);
            }
            lv.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].ISBN);
                lvi.SubItems.Add(list[i].Name);
                lvi.SubItems.Add(list[i].Author);
                lvi.SubItems.Add(list[i].bookCate.Name);
                lvi.SubItems.Add(list[i].Publisher);
                lvi.SubItems.Add(list[i].PublishDate);
                lvi.SubItems.Add(list[i].Price.ToString());
                lvi.SubItems.Add(list[i].KeyWords);
                lvi.SubItems.Add(list[i].Language);
                lvi.SubItems.Add(list[i].TotalCount.ToString());
                lvi.SubItems.Add(list[i].Operator.name);
                lvi.SubItems.Add(list[i].IsBorrow ? "是" : "否");
                lv.Items.Add(lvi);
            }
        }
        
        string MakeColName(int index)
        {
            string name;
            switch(index)
            {
                case 0:
                    name = "ISBN";
                    break;
                case 1:
                    name = "Name";
                    break;
                case 2:
                    name = "Author";
                    break;
                case 3:
                    name = "BookCate";
                    break;
                case 4:
                    name = "Publisher";
                    break;
                case 5:
                    name = "PublishDate";
                    break;
                case 6:
                    name = "Price";
                    break;
                case 7:
                    name = "KeyWords";
                    break;
                case 8:
                    name = "Language";
                    break;
                case 9:
                    name = "TotalCount";
                    break;
                case 10:
                    name = "Operator";
                    break;
                default:
                    name = "Name";
                    break;
            }
            return name;
        }
    }
}
