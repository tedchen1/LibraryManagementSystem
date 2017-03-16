using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace ClassLibrary
{
    //数据库操作接口的实现(SQLite)
    //
    public class SQLiteConn : DataBaseConn
    {
        //数据库连接字符串
        private String connString = null;
        //错误信息
        private String errorString = null;
        private int errorCode = 0;
        //静态数据库连接
        private static SQLiteConnection conn = null;
        //日志类
        private Log log = null;
        //构造方法
        public SQLiteConn()
        {
            this.log = new DBErrorLog();
            //如果连接为空，就new一个
            try
            {
                if (conn == null)
                {
                    //从App.config文件中获取连接字符串
                    connString = System.Configuration.ConfigurationManager.AppSettings["connection"];
                    conn = new SQLiteConnection(connString);
                }
            }
            catch (DbException ex)
            {
                errorString = ex.Message;
                errorCode = ex.ErrorCode;
                String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                log.write(errorCode.ToString(), error, "null");
            }

        }
        //析构函数
        ~SQLiteConn()
        {
            //C#会自己释放，不需要手动释放
        }
        public SQLiteConn(String connString)
        {
            this.log = new DBErrorLog();
            //如果连接为空，就new一个
            try
            {
                if (conn != null)
                {
                    close(); 
                }
                this.connString = connString;
                conn = new SQLiteConnection(connString);
            }
            catch (DbException ex)
            {
                errorString = ex.Message;
                errorCode = ex.ErrorCode;
                String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                log.write(errorCode.ToString(), error, "null");
            }
            
        }
        //获取连接状态
        public ConnectionState getState()
        {
            return conn.State;
        }
        //获取连接字符串
        public String getConnString()
        {
            return connString;
        }
        //获取错误字信息
        public String getErrorString()
        {
            return errorString;
        }
        public int getErrorCode()
        {
            //19 有内容跟唯一项重复
            //...其他
            return errorCode;
        }
        //打开数据库
        public void open() {
            errorCode = 0;
            errorString = "";
            //判断是否已经打开
            if (conn.State != ConnectionState.Open) 
            {
                try
                {
                    conn.Open();
                }
                catch (DbException ex)
                {
                    errorString = ex.Message;
                    errorCode = ex.ErrorCode;
                    String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                    log.write(errorCode.ToString(), error, "null");
                }
            }
        }
        //关闭数据库
        public void close()
        {
            errorCode = 0;
            errorString = "";
            try
            {
                conn.Close();
            }
            catch (DbException ex)
            {
                errorString = ex.Message;
                errorCode = ex.ErrorCode;
                String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                log.write(errorCode.ToString(), error, "null");
            }
        }
        //执行非查询语句
        public int execNonSQL(String sql)
        {
            errorCode = 0;
            errorString = "";
            int ret = 0;
            try
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (DbException ex)
            {
                errorString = ex.Message;
                errorCode = ex.ErrorCode;
                String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                log.write(errorCode.ToString(), error, "null");
            }

            return ret;
        }
        //执行查询语句
        public DbDataReader execReader(String sql)
        {
            errorCode = 0;
            errorString = "";
            DbDataReader reader = null;
            try
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    reader = cmd.ExecuteReader();
                }
            }
            catch (DbException ex)
            {
                errorString = ex.Message;
                errorCode = ex.ErrorCode;
                String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                log.write(errorCode.ToString(), error, "null");
            }

            return reader;
        }
        //获取第一行第一列的值
        public object execScalar(String sql)
        {
            errorCode = 0;
            errorString = "";
            object obj = null;
            try
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    obj = cmd.ExecuteScalar();
                }
            }
            catch (DbException ex)
            {
                errorString = ex.Message;
                errorCode = ex.ErrorCode;
                String error = "Source:" + ex.Source + " StackTrace:" + ex.StackTrace + " Target:" + ex.TargetSite.Name +
                    errorString;
                log.write(errorCode.ToString(), error, "null");
            }
            return obj;
        }
    }
}
