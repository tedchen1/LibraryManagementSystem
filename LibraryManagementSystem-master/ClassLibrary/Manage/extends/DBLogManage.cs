using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class DBLogManage : Manage
    {
        public DBLogManage(LibraryManage lm)
            : base(lm)
        {

        }
        public List<DBLog> getLogList()
        {
            return user.logRights.getLogList();
        }
        public List<DBLogCate> getLogCateList()
        {
            return user.logRights.getLogCateList();
        }
        public List<DBLog> serachLog(String LogCate, String OperateCode, DateTime start, DateTime end)
        {
            return user.logRights.serachLog(LogCate, OperateCode, start, end);
        }
    }
}
