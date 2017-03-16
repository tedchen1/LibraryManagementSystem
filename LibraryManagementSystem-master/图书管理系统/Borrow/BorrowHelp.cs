using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowHelp : Form
    {
        public BorrowHelp()
        {
            InitializeComponent();
        }

        private void BorrowHelp_Load(object sender, EventArgs e)
        {
            textBox2.SelectionStart = 0;
        }
    }
}
