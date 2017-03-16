using System;
using System.Collections.Generic;
using System.Data.Common;

namespace ClassLibrary
{
    public class UserRights : Rights
    {
        public UserRights(LibraryManage lm)
            : base(lm)
        {
        }
        //更新密码，因为所有人都可以更改自己的密码，所以不放到用户权限里面
        //public void UpdatewdD(String oldPwd, String newPwd)
        //{

        //}
        //增加用户
        public bool addUser(User u,String PWD)
        {
            String sql = String.Format("insert into Users values(null," + 
                "'{0}' , '{1}' , '{2}' , {3} , {4} , {5} , {6} , {7} , {8} , {9})",  
            u.code,
            PWD,
            u.name,
            u.isLock ? 1 : 0,
            u.userRights != null ? 1 : 0,
            u.bookRights != null ? 1 : 0,
            u.readerRights != null ? 1 : 0,
            u.borrowRights != null ? 1 : 0,
            u.logRights != null ? 1 : 0,
            u.bakRights != null ? 1 : 0
            );
            int ret = 0;
            try
            {
                ret = conn.execNonSQL(sql);
                if (ret == 1)
                {
                    return true;
                }
            }
            catch (DbException)
            {
                return false;
            }

            return false;
        }
        //更新用户资料
        public bool updateUser(User u)
        {
            String sql = String.Format("Update Users set Name='{0}' , " +
            "IsLock={1} ,IsUserRight={2} ,IsBookRight={3} ,IsReaderRight={4} ,IsBorrowRight={5} ,IsLogRight={6} ,IsBakRight={7} " + 
            "where Code = '{8}';",  
            u.name,
            u.isLock ? 1 : 0,
            u.userRights != null ? 1 : 0,
            u.bookRights != null ? 1 : 0,
            u.readerRights != null ? 1 : 0,
            u.borrowRights != null ? 1 : 0,
            u.logRights != null ? 1 : 0,
            u.bakRights != null ? 1 : 0,
            u.code
            );
            int ret = 0;
            try
            {
                ret = conn.execNonSQL(sql);
                if (ret == 1)
                {
                    return true;
                }
            }
            catch (DbException)
            {
                return false;
            }

            return false;
        }
        //删除用户
        public bool delUser(User u)
        {
            bool ret = false;
            //不能删除管理员账号
            if (1 == u.id)
            {
                return false;
            }
            String sql = String.Format("delete from Users where Id={0}", u.id);
            int row = conn.execNonSQL(sql);
            if (1 == row)
            {
                ret = true;
            }
            return ret;
        }
        //获取所有的用户
        public List<User> getUserList()
        {
            List<User> list = new List<User>();
            String sql = String.Format("select " +
               "Id , Code , Name , IsLock , IsUserRight , IsBookRight ," +
               "IsReaderRight , IsBorrowRight , IsLogRight , IsBakRight " +
               "from Users");
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        User u = new User();
                        u.id = Convert.ToInt32(reader[0]);
                        u.code = reader[1].ToString();
                        u.name = reader[2].ToString();
                        u.isLock = Convert.ToBoolean(reader[3]);
                        u.userRights = Convert.ToBoolean(reader[4]) ? new UserRights(libraryManage) : null;
                        u.bookRights = Convert.ToBoolean(reader[5]) ? new BookRights(libraryManage) : null;
                        u.readerRights = Convert.ToBoolean(reader[6]) ? new ReaderRights(libraryManage) : null;
                        u.borrowRights = Convert.ToBoolean(reader[7]) ? new BorrowRights(libraryManage) : null;
                        u.logRights = Convert.ToBoolean(reader[8]) ? new LogRights(libraryManage) : null;
                        u.bakRights = Convert.ToBoolean(reader[9]) ? new BakRights(libraryManage) : null;
                        list.Add(u);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
        //检测用户输入的密码是否与真实密码一致，同更新密码
        public List<User> findUser(String attr, String value)
        {
            List<User> list = new List<User>();
            String sql = String.Format("select " +
               "Id , Code , Name , IsLock , IsUserRight , IsBookRight ," +
               "IsReaderRight , IsBorrowRight , IsLogRight , IsBakRight " +
               "from Users where {0} like '%{1}%'", attr, value);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        User u = new User();
                        u.id = Convert.ToInt32(reader[0]);
                        u.code = reader[1].ToString();
                        u.name = reader[2].ToString();
                        u.isLock = Convert.ToBoolean(reader[3]);
                        u.userRights = Convert.ToBoolean(reader[4]) ? new UserRights(libraryManage) : null;
                        u.bookRights = Convert.ToBoolean(reader[5]) ? new BookRights(libraryManage) : null;
                        u.readerRights = Convert.ToBoolean(reader[6]) ? new ReaderRights(libraryManage) : null;
                        u.borrowRights = Convert.ToBoolean(reader[7]) ? new BorrowRights(libraryManage) : null;
                        u.logRights = Convert.ToBoolean(reader[8]) ? new LogRights(libraryManage) : null;
                        u.bakRights = Convert.ToBoolean(reader[9]) ? new BakRights(libraryManage) : null;
                        list.Add(u);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
    }
}
