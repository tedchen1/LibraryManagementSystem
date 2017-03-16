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
    public partial class FindUser : Form
    {
        public FindUser()
        {
            InitializeComponent();
        }

        ListView lv;
        LibraryManage libraryManage = null;
        List<User> list = null;
        private void FindBook_Load(object sender, EventArgs e)
        {
            cb_LogCate.SelectedIndex = 0;
        }
        public void Show(List<User> list, ListView lv, LibraryManage lm)
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
            List<User> tmp = libraryManage.userManage.findUser(colname, textBox1.Text);
            foreach (User u in tmp)
            {
                list.Add(u);
            }
            lv.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].id.ToString();
                lvi.SubItems.Add(list[i].code);
                lvi.SubItems.Add(list[i].name);
                lvi.SubItems.Add(list[i].isLock ? "是" : "否");
                lvi.SubItems.Add(list[i].userRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].bookRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].readerRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].borrowRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].logRights != null ? "有" : "无");
                lvi.SubItems.Add(list[i].bakRights != null ? "有" : "无");
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
