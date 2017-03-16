using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Manage
    {
        protected LibraryManage libraryManage = null;
        protected DataBaseConn conn = null;
        protected User user = null;
        protected Log log = null;
        public Manage(LibraryManage lm)
        {
            libraryManage = lm;
            this.conn = libraryManage.conn;
            user = libraryManage.user;
            log = libraryManage.log;
        }
    }
}
