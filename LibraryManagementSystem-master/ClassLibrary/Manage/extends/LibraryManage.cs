using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class LibraryManage
    {
        //数据库连接
        private DataBaseConn m_conn = null;
        //数据库连接字符串
        private String dbConnString = null;
        //用户名历史记录
        private String[] names = null;
        //最后登陆的用户名
        private String lastName = null;
        //数据库文件地址
        private String dbPath = null;
        //当前用户
        private User m_user = null;
        //数据库文件的默认后缀名
        private String m_suffix = null;
        //日志类
        private Log m_log = null;
        //借阅花费
        private double borrowCosts = 0;
        //逾期费用
        private double lateFee = 0;
        //权限变量
        private UserManage m_userManage = null;
        private BakManage m_bakManage = null;
        private DBLogManage m_dbLogManage = null;
        private ReaderManage m_readerManage = null;
        private BookManage m_bookManage = null;
        private BorrowManage m_borrowManage = null;

        public LibraryManage()
        {
            IniFile ini = new IniFile(".\\Library.ini");

            #region 系统设定相关
            //获取数据库文件的地址
            dbPath = ini.IniReadValue("System", "dbPath");
            //数据库的后缀名
            m_suffix = ini.IniReadValue("System", "dbSuffix");
            #endregion

            #region 用户设定相关
            //历史登陆用户名单
            names = ini.IniReadValue("User", "List").Split(',');
            //最后登陆的用户名
            lastName = ini.IniReadValue("User", "LastName");
            #endregion

            #region 费用设定相关
            //借阅费用
            if ("" == ini.IniReadValue("Cost", "borrowCosts"))
            {
                borrowCosts = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["borrowCosts"]);
            }
            else
            {
                borrowCosts = Convert.ToDouble(ini.IniReadValue("Cost", "borrowCosts"));
            }
            //逾期费用
            if ("" == ini.IniReadValue("Cost", "lateFee"))
            {
                lateFee = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["lateFee"]);
            }
            else
            {
                lateFee = Convert.ToDouble(ini.IniReadValue("Cost", "lateFee"));
            }
            #endregion

            if ("" == dbPath)
            {
                dbPath = System.Configuration.ConfigurationManager.AppSettings["dbName"];
            }
            if ("" == m_suffix)
            {
                m_suffix = System.Configuration.ConfigurationManager.AppSettings["suffix"];
            }
            if ("" == names[0])
            {
                names = new String[] {};
            }
            dbConnString = String.Format("Data Source={0};Pooling=true;FailIfMissing=true", dbPath);

        }
        ~LibraryManage()
        {
            //MessageBox.Show("awf");
        }

        #region 权限相关
        public UserManage userManage
        {
            get
            {
                return m_userManage;
            }
        }
        public BakManage bakManage
        {
            get
            {
                return m_bakManage;
            }
        }
        public DBLogManage DBLogManage
        {
            get
            {
                return m_dbLogManage;
            }
        }
        public ReaderManage readerManage
        {
            get
            {
                return m_readerManage;
            }
        }
        public BookManage bookManage
        {
            get
            {
                return m_bookManage;
            }
        }
        public BorrowManage borrowManage
        {
            get
            {
                return m_borrowManage;
            }
        }
        #endregion

        #region 方法
        public bool login(String code, String pwd)
        {
            User u = m_user;
            bool ret = false;
            //除去空格
            code = code.Trim();
            //加密
            pwd = UserManage.MD5(pwd.Trim());
            //select * from Users limit 0,1
            String sql = String.Format("select " +
                "Id,Code,Name,IsLock,IsUserRight,IsBookRight," + 
                "IsReaderRight,IsBorrowRight,IsLogRight,IsBakRight " + //有空格
                "from Users where " +   //有空格
                "Code='{0}' and Password='{1}' limit 0,1",code,pwd);
            try
            {
                using (DbDataReader reader = m_conn.execReader(sql))
                {
                    ret = reader.Read();
                    if(ret)
                    {
                        u.id = Convert.ToInt32(reader[0]);
                        u.code = reader[1].ToString();
                        u.name = reader[2].ToString();
                        u.isLock = Convert.ToBoolean(reader[3]);
                        u.userRights = Convert.ToBoolean(reader[4]) ? new UserRights(this) : null;
                        u.bookRights = Convert.ToBoolean(reader[5]) ? new BookRights(this) : null;
                        u.readerRights = Convert.ToBoolean(reader[6]) ? new ReaderRights(this) : null;
                        u.borrowRights = Convert.ToBoolean(reader[7]) ? new BorrowRights(this) : null;
                        u.logRights = Convert.ToBoolean(reader[8]) ? new LogRights(this) : null;
                        u.bakRights = Convert.ToBoolean(reader[9]) ? new BakRights(this) : null;
                        log.write("用户登陆", u.code, u.code);
                    }
                }
            }
            catch (DbException)
            {
                ret = false;
            }
            return ret;
        }
        //数据库文件是否存在
        public bool isDbExits()
        {
            if (File.Exists(dbPath))
            {
                return true;
            }
            return false;
        }
        //数据库是否正常
        public bool isDb()
        {
            SQLiteConn conn = new SQLiteConn(dbConnString);
            try
            {
                //竟然啥文件都能打开成功!!!!!!
                conn.open();
                //测试是否是数据库...
                //简单测试数据库是否正确
                conn.execNonSQL("select Code from Users");
                if (ConnectionState.Open == conn.getState())
                {
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                StreamWriter log = new StreamWriter("error.log", true);
                log.WriteLine("{0} Message:{1} Source:{2} TargetSite:{3} ErrorCode:{4}", DateTime.Now.ToString(), ex.Message, ex.Source, ex.TargetSite, ex.ErrorCode);
                log.Close();
                return false;
            }

            return false;
        }
        public bool isDb(String path)
        {
            String dbConnString = String.Format("Data Source={0};Pooling=true;FailIfMissing=true", path);
            SQLiteConn conn = new SQLiteConn(dbConnString);
            try
            {
                //竟然啥文件都能打开成功!!!!!!
                conn.open();
                //测试是否是数据库...
                //简单测试数据库是否正确
                conn.execNonSQL("select Code from Users");
                if (ConnectionState.Open == conn.getState())
                {
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                StreamWriter log = new StreamWriter("error.log", true);
                log.WriteLine("{0} Message:{1} Source:{2} TargetSite:{3} ErrorCode:{4}", DateTime.Now.ToString(), ex.Message, ex.Source, ex.TargetSite, ex.ErrorCode);
                log.Close();
                return false;
            }

            return false;
        }
        //初始化
        public void init()
        {
            m_user = new User();
            m_conn = new SQLiteConn(dbConnString);
            m_conn.open();
            //初始化日志类
            m_log = new Operation(m_conn);
            //功能模块初始化
            m_userManage = new UserManage(this);
            m_bakManage = new BakManage(this);
            m_dbLogManage = new DBLogManage(this);
            m_readerManage = new ReaderManage(this);
            m_bookManage = new BookManage(this);
            m_borrowManage = new BorrowManage(this);
        }
        //系统退出处理
        public void exit()
        {
            IniFile ini = new IniFile(".\\Library.ini");

            ini.IniWriteValue("System", "dbPath",dbPath);
            ini.IniWriteValue("System", "dbSuffix", m_suffix);
            ini.IniWriteValue("Cost", "borrowCosts", borrowCosts.ToString());
            ini.IniWriteValue("Cost", "lateFee", lateFee.ToString());

            String name;
            if (!isUserExitsList(out name))
            {
                ini.IniWriteValue("User", "List", name);
            }
            ini.IniWriteValue("User", "LastName",user.code);
        }
        //用户类
        public User user
        {
            get
            {
                return m_user;
            }
            set
            {
                //暂时没有需求
            }
        }
        //
        public DataBaseConn conn
        {
            get
            {
                return m_conn;
            }
        }
        //重新连接数据库
        public void ReConn()
        {
            if (ConnectionState.Open == m_conn.getState())
            {
                m_conn.close();
                m_conn = new SQLiteConn(dbConnString);
                m_conn.open();
            }
        }
        //获取用户历史列表
        public String[] getNameList()
        {
            return names;
        }
        //获取最后登陆的用户名
        public String getLastName()
        {
            return lastName;
        }
        #endregion

        #region 属性设置相关
        //获取数据库文件的地址
        public String getDbPath()
        {
            return dbPath;
        }
        public void setDbPath(String path)
        {
            dbPath = path;
            dbConnString = String.Format("Data Source={0};Pooling=true;FailIfMissing=true", dbPath);
        }
        //获取数据库文件的连接字符串
        public String getDbConnString()
        {
            return dbConnString;
        }
        //设置数据库连接字符串
        public void setDbConnString(String connString)
        {
            dbConnString = connString;
        }
        //获取数据库文件的后缀名
        public String getDbSuffix()
        {
            return m_suffix;
        }
        public void setDbSuffix(String suffix)
        {
            m_suffix = suffix;
        }
        //日志
        public Log log
        {
            get
            {
                return m_log;
            }
        }
        public double getBorrowCost()
        {
            return borrowCosts;
        }
        public double getLateFee()
        {
            return lateFee;
        }
        public void setBorrowCost(double cost)
        {
            borrowCosts = cost;
        }
        public void setLateFee(double cost)
        {
            lateFee = cost;
        }
        #endregion

        private bool isUserExitsList(out String list)
        {
            list = "";
            foreach(String name in names){
                if (m_user.code == name)
                {
                    return true;
                }
            }
            foreach (String name in names)
            {
                list += name + ",";
            }
            list += m_user.code;
            return false;
        }

        public int getBookCount()
        {
            String sql = String.Format("select count(*) from Books");
            int ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }
        public int getReaderCount()
        {
            String sql = String.Format("select count(*) from Readers");
            int ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }
        public int getBorrowCount()
        {
            String sql = String.Format("select count(*) from BorrowRecord");
            int ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }
    }
}
