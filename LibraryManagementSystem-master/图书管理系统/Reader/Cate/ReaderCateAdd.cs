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
    public partial class ReaderCateAdd : Form
    {
        LibraryManage libraryManage = null;
        DialogResult m_DialogResult;
        public ReaderCateAdd(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            m_DialogResult = System.Windows.Forms.DialogResult.No;
            n_Discount.DecimalPlaces = 2;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if ("" == tb_Name.Text)
            {
                MessageBox.Show("名称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_Name.Focus();
                return;
            }

            ReaderCate cate = new ReaderCate();
            cate.Id = 0;
            cate.LimitBooksCount = Convert.ToInt32(n_BookCnt.Value);
            cate.LimitDays = Convert.ToInt32(n_Bd.Value);
            cate.Name = tb_Name.Text;
            cate.ReBorrowDays = Convert.ToInt32(n_Rd.Value);
            cate.ReBorrowTimes = Convert.ToInt32(n_Rt.Value);
            cate.Discount = Convert.ToDouble(n_Discount.Value / 100);

            if (libraryManage.readerManage.addReaderCate(cate))
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
                        errorString = "角色重复，添加失败";
                        break;
                    default:
                        errorString = "添加失败";
                        break;
                }
                MessageBox.Show(errorString, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (false == cb_add.Checked)
                {
                    this.DialogResult = m_DialogResult;
                }
            }
        }
        void clear()
        {
            tb_Name.Text = "";
            n_BookCnt.Value = 0;
            n_Bd.Value = 0;
            n_Rt.Value = 0;
            n_Rd.Value = 0;
            tb_Name.Focus();
        }
    }
}
