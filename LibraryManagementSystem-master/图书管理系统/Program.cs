using ClassLibrary;
using System;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;

namespace 图书管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            SQLiteConn conn = new SQLiteConn();
            conn.open();
            DbDataReader reader = conn.execReader("select Code from Users where Code REGEXP(20)");
            while (reader.Read())
            {
                MessageBox.Show(reader[0].ToString());
            }
            */
             
            LibraryManage libraryManage = new LibraryManage();
            if (!libraryManage.isDbExits())
            {
                MessageBox.Show("数据库文件不存在于以下位置:\n" + libraryManage.getDbPath(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!libraryManage.isDb())
            {
                MessageBox.Show("数据库是损坏的！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //初始化
            libraryManage.init();

            login m_login = new login(libraryManage); 
            if( m_login.ShowDialog()== DialogResult.Yes)
            {
                SystemMain sm = new SystemMain(libraryManage);
                Application.Run(sm);
                libraryManage.exit();
            }
            
            //测试借阅功能
            //Application.Run(new BorrowManage("liyifan"));
        }
    }
}
