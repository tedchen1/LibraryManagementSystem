using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class SystemSetting : Form
    {
        LibraryManage libraryManage = null;
        public SystemSetting(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            libraryManage.setBorrowCost(Convert.ToDouble(jieyue.Value));
            libraryManage.setLateFee(Convert.ToDouble(chaoqi.Value));
            Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SystemSetting_Load(object sender, EventArgs e)
        {
            jieyue.DecimalPlaces = 2;
            chaoqi.DecimalPlaces = 2;
        }
    }
}
