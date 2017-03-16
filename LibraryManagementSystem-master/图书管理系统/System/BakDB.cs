using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

using System.Text;

using System.Windows.Forms;
using System.Configuration;
using ClassLibrary;

namespace 图书管理系统
{
    public partial class BakDB : Form
    {
        LibraryManage libraryManage = null;
        public BakDB(LibraryManage lm)
        {
            InitializeComponent();
            libraryManage = lm;
        }

        private void btn_foloder_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                tb_folder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_recover_Click(object sender, EventArgs e)
        {
             if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                 bool copyToCurr = MessageBox.Show("是否将数据库文件拷贝到当前目录下？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes ? true : false;
                 if (libraryManage.bakManage.RecoverFile(openFileDialog1.FileName, copyToCurr))
                {
                    MessageBox.Show("恢复成功!");
                    //Log.Write("恢复数据", Code, openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("恢复失败!请检查要恢复的备份文件是否损坏!");
                }
             }
        }

        private void btn_bak_Click(object sender, EventArgs e)
        {
            if("" == tb_folder.Text)
            {
                MessageBox.Show("请选择备份目录!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            string source = tb_dbPath.Text;

            if(libraryManage.bakManage.bakDb(tb_folder.Text))
            {
                MessageBox.Show("备份成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Log.Write("备份数据", Code, dest);
            }
            else
            {
                MessageBox.Show("备份失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BakDB_Load(object sender, EventArgs e)
        {
            tb_dbPath.Text = libraryManage.getDbPath();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
