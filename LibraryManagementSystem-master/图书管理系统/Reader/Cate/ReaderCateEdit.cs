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
    public partial class ReaderCateEdit : Form
    {
        ReaderCate cate = null;
        LibraryManage libraryManage = null;
        public ReaderCateEdit(ReaderCate c, LibraryManage lm)
        {
            InitializeComponent();
            cate = c;
            libraryManage = lm;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            tb_Name.Text = cate.Name;
            n_BookCnt.Value = cate.LimitBooksCount;
            n_Bd.Value = cate.LimitDays;
            n_Rt.Value = cate.ReBorrowTimes;
            n_Rd.Value = cate.ReBorrowDays;
            n_Discount.DecimalPlaces = 2;
            n_Discount.Value = Convert.ToDecimal(cate.Discount * 100);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if("" == tb_Name.Text)
            {
                MessageBox.Show("昵称不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                tb_Name.Focus();
                return;
            }

            ReaderCate cate = new ReaderCate();
            cate.Id = this.cate.Id;
            cate.LimitBooksCount = Convert.ToInt32(n_BookCnt.Value);
            cate.LimitDays = Convert.ToInt32(n_Bd.Value);
            cate.Name = tb_Name.Text;
            cate.ReBorrowDays = Convert.ToInt32(n_Rd.Value);
            cate.ReBorrowTimes = Convert.ToInt32(n_Rt.Value);
            cate.Discount = Convert.ToDouble(n_Discount.Value / 100);

            if (libraryManage.readerManage.upReaderCate(cate))
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
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
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
            
        }
    }
}
