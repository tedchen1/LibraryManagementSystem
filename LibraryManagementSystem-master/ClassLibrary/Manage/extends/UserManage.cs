using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary
{
    public class UserManage : Manage
    {
        public UserManage(LibraryManage lm) : base(lm)
        {
        }
        //获取所有的用户
        public List<User> getUserList()
        {
            return user.userRights.getUserList();
        }
        /// <summary>
        /// 用户密码加密
        /// </summary>
        /// <param name="strPwd">密码明文</param>
        /// <returns>加密后的密码</returns>
        static public string MD5(string strPwd)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(strPwd)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }
        //每个人都能更新自己的密码，所以单独列出来
        public bool updatePWD(String newPwd)
        {
            bool ret = false;
            newPwd = MD5(newPwd);
            string sql = string.Format("update Users set Password='{0}' where Id = {1};",
            newPwd, user.id);
            int row = conn.execNonSQL(sql);
            if (1 == row)
            {
                ret = true;
                log.write("更新密码", newPwd, user.code);
            }
            return ret;
        }
        public bool checkPwd(String pwd)
        {
            bool ret = false;
            pwd = MD5(pwd);
            string sql = string.Format("select " +
               "Id " +
               "from Users where Id = {0} and Password = '{1}'",user.id,pwd);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    ret = reader.HasRows;
                }
            }
            catch (Exception)
            {
                
            }
            
            return ret;
        }
        public bool delUser(User u)
        {
            bool ret = user.userRights.delUser(u);
            if (true == ret)
            {
                String val = u.ToString();
                log.write("删除用户", val, user.code);
            }
            return ret;
        }
        public bool addUser(User u)
        {
            string PWD = MD5("");
            bool ret = user.userRights.addUser(u, PWD);
            if (true == ret)
            {
                String val = u.ToString();
                log.write("新增用户", val, user.code);
            }
            return ret;
        }
        public bool upUser(User u)
        {
            bool ret = user.userRights.updateUser(u);
            if (true == ret)
            {
                String val = u.ToString();
                log.write("修改用户", val, user.code);
            }
            return ret;
        }
        public List<User> findUser(String attr, String value)
        {
            return user.userRights.findUser(attr, value);
        }
    }
}
