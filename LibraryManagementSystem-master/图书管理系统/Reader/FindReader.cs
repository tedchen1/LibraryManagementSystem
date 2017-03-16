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
    public partial class FindReader : Form
    {
        public FindReader()
        {
            InitializeComponent();
        }

        ListView lv;
        LibraryManage libraryManage = null;
        List<Reader> list = null;
        private void FindBook_Load(object sender, EventArgs e)
        {
            cb_LogCate.SelectedIndex = 0;
        }
        public void Show(List<Reader> list, ListView lv, LibraryManage lm)
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
            List<Reader> tmp = libraryManage.readerManage.findReader(colname, textBox1.Text);
            foreach (Reader r in tmp)
            {
                list.Add(r);
            }
            lv.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].Id.ToString();
                lvi.SubItems.Add(list[i].Code);
                lvi.SubItems.Add(list[i].Name);
                lvi.SubItems.Add(list[i].Sex);
                lvi.SubItems.Add(list[i].Phone);
                lvi.SubItems.Add(list[i].Email);
                lvi.SubItems.Add(list[i].RegDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(list[i].Cate.Name);
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
                    name = "Code";
                    break;
                case 1:
                    name = "Name";
                    break;
                default:
                    name = "Code";
                    break;
            }
            return name;
        }
    }
}
