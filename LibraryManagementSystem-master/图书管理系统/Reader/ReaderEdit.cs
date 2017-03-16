using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class ReaderEdit : Form
    {
        Reader reader = null;
        LibraryManage libraryManage = null;
        List<ReaderCate> list = null;
        public ReaderEdit(Reader r, LibraryManage lm)
        {
            InitializeComponent();
            reader = r;
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            list = libraryManage.readerManage.getReaderCateList();
            for (int i = 0; i < list.Count; i++)
            {
                cb_Cate.Items.Add(list[i].Name);
            }

            tb_Code.Text = reader.Code;
            tb_Name.Text = reader.Name;
            cb_Sex.Text = reader.Sex;
            tb_Phone.Text = reader.Phone;
            tb_Email.Text = reader.Email;
            cb_Cate.Text = reader.Cate.Name;
            checkBox1.Checked = reader.IsBorrow;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_Name.Text)
            {
                MessageBox.Show("昵称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_Code.Focus();
                return;
            }

            if("" != tb_Email.Text)
            {
                if (!Regex.IsMatch(tb_Email.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    MessageBox.Show("请输入正确的邮箱格式!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tb_Email.Focus();
                    return;
                }
            }

            Reader reader = new Reader();
            reader.Id = this.reader.Id;
            reader.Cate = list[cb_Cate.SelectedIndex];
            reader.Code = tb_Code.Text;
            reader.Email = tb_Email.Text;
            reader.IsBorrow = checkBox1.Checked;
            reader.Name = tb_Name.Text;
            reader.Phone = tb_Phone.Text;
            reader.RegDate = DateTime.Now;
            reader.Sex = cb_Sex.Text;

            if (libraryManage.readerManage.upReader(reader))
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
            
        }
    }
}
