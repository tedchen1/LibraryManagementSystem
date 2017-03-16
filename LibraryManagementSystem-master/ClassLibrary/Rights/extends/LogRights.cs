using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class LogRights : Rights
    {
        public LogRights(LibraryManage lm)
            : base(lm)
        {

        }
        public List<DBLog> getLogList()
        {
            List<DBLog> list = new List<DBLog>();
            String sql = String.Format("select * from UserLog");
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        DBLog log = new DBLog();
                        log.Id = Convert.ToInt32(reader[0]);
                        log.LogDate = reader[1].ToString();
                        log.LogCate = reader[2].ToString();
                        log.OperateCode = reader[3].ToString();
                        log.Message = reader[4].ToString();
                        list.Add(log);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
        public List<DBLogCate> getLogCateList()
        {
            List<DBLogCate> list = new List<DBLogCate>();
            String sql = String.Format("select * from LogCate");
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        DBLogCate log = new DBLogCate();
                        log.Id = Convert.ToInt32(reader[0]);
                        log.Name = reader[1].ToString();
                        list.Add(log);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
        public List<DBLog> serachLog(String LogCate, String OperateCode, DateTime start, DateTime end)
        {
            List<DBLog> list = new List<DBLog>();
            String sql = "select Id,LogDate,LogCate,OperateCode,Message " +
                "from UserLog";

            if ("全部" == LogCate)
            {
                LogCate = "";
            }

            if ("全部" == OperateCode)
            {
                OperateCode = "";
            }

            String where = String.Format(" where LogCate like '{0}%' and OperateCode like '{1}%' and " +
                "LogDate > datetime('{2}') and LogDate <= datetime('{3}');",
                LogCate, OperateCode,
                start.ToString("yyyy-MM-dd"),
                end.ToString("yyyy-MM-dd 23:59:59")
                );
            sql += where;
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        DBLog log = new DBLog();
                        log.Id = Convert.ToInt32(reader[0]);
                        log.LogDate = reader[1].ToString();
                        log.LogCate = reader[2].ToString();
                        log.OperateCode = reader[3].ToString();
                        log.Message = reader[4].ToString();
                        list.Add(log);
                    }
                }
            }
            catch (DbException)
            {

            }

            return list;
        }
    }
}
