using System;

namespace ClassLibrary
{
    public class User
    {
        private int m_id;
        private string m_code;
        private string m_name;
        private bool m_isLock;
        //各个权限单独用类来实现
        private UserRights m_userRight = null;
        private BakRights m_bakRight = null;
        private ReaderRights m_readerRight = null;
        private BorrowRights m_borrowRight = null;
        private LogRights m_logRight = null;
        private BookRights m_bookRight = null;

        public User()
        {

        }
        // set get 方法
        //用户id
        public int id
        {
            get
            {
                return this.m_id;
            }
            set
            {
                m_id = value;
            }
        }
        //用户账号
        public String code
        {
            get
            {
                return this.m_code;
            }
            set
            {
                m_code = value;
            }
        }
        //用户昵称
        public String name
        {
            get
            {
                return this.m_name;
            }
            set
            {
                m_name = value;
            }
        }
        //是否被锁定
        public bool isLock
        {
            get
            {
                return this.m_isLock;
            }
            set
            {
                m_isLock = value;
            }
        }
        //用户权限
        public UserRights userRights
        {
            get
            {
                return m_userRight;
            }
            set
            {
                m_userRight = value;
            }
        }
        //备份权限
        public BakRights bakRights
        {
            get
            {
                return m_bakRight;
            }
            set
            {
                m_bakRight = value;
            }
        }
        //图书权限
        public BookRights bookRights
        {
            get
            {
                return m_bookRight;
            }
            set
            {
                m_bookRight = value;
            }
        }
        //借阅权限
        public BorrowRights borrowRights
        {
            get
            {
                return m_borrowRight;
            }
            set
            {
                m_borrowRight = value;
            }
        }
        //日志权限
        public LogRights logRights
        {
            get
            {
                return m_logRight;
            }
            set
            {
                m_logRight = value;
            }
        }
        //读者权限
        public ReaderRights readerRights
        {
            get
            {
                return m_readerRight;
            }
            set
            {
                m_readerRight = value;
            }
        }
        //将用户的信息生成文本形式
        public override String ToString()
        {
            String val = String.Format("ID:{0} code:{1} name:{2} islock:{3} userRight:{4} bakRight:{5} bookRight:{6} borrowRight:{7} logRight:{8} readerRight:{9}",
                m_id,m_code,m_name,m_isLock,
                m_userRight !=null ? 1 : 0,
                m_bakRight !=null ? 1 : 0,
                m_bookRight !=null ? 1 : 0,
                m_borrowRight !=null ? 1 : 0,
                m_logRight !=null ? 1 : 0,
                m_readerRight !=null ? 1 : 0
                );
            return val;
        }
    }
}
