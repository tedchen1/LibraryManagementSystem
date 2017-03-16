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
    public partial class ReaderAdd : Form
    {
        LibraryManage libraryManage = null;
        List<ReaderCate> list = null;
        DialogResult m_DialogResult;
        public ReaderAdd(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = m_DialogResult;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            m_DialogResult = System.Windows.Forms.DialogResult.No;
            cb_Sex.SelectedIndex = 0;
            list = libraryManage.readerManage.getReaderCateList();
            for (int i = 0; i < list.Count; i++)
            {
                cb_Cate.Items.Add(list[i].Name);
            }
            cb_Cate.SelectedIndex = 0;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_Code.Text || "" == tb_Name.Text)
            {
                MessageBox.Show("账号,昵称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_Code.Focus();
                return;
            }

            Reader reader = new Reader();
            reader.Id = 0;
            reader.Cate = list[cb_Cate.SelectedIndex];
            reader.Code = tb_Code.Text;
            reader.Email = tb_Email.Text;
            reader.IsBorrow = checkBox1.Checked;
            reader.Name = tb_Name.Text;
            reader.Phone = tb_Phone.Text;
            reader.RegDate = DateTime.Now;
            reader.Sex = cb_Sex.Text;

            if (libraryManage.readerManage.addReader(reader))
            {
                m_DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (true == cb_add.Checked)
                {
                    clear();
                }
                else
                {
                    this.DialogResult = m_DialogResult;
                }
            }
            else
            {
                m_DialogResult = System.Windows.Forms.DialogResult.No;
                String errorString = "";
                switch (libraryManage.conn.getErrorCode())
                {
                    //字段信息重复
                    case 19:
                        errorString = "账号重复，添加失败";
                        break;
                    default:
                        errorString = "添加失败";
                        break;
                }
                MessageBox.Show(errorString, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Code.Focus();
            }
            
        }

        void clear()
        {
            tb_Code.Text = "";
            tb_Name.Text = "";
            cb_Cate.SelectedIndex = 0;
            cb_Sex.SelectedIndex = 0;
            tb_Phone.Text = "";
            tb_Email.Text = "";
            tb_Code.Focus();
        }
    }
}
