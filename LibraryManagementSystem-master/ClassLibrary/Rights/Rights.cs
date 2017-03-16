using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Rights
    {
        protected LibraryManage libraryManage = null;
        protected DataBaseConn conn = null;
        protected Rights(LibraryManage lm)
        {
            libraryManage = lm;
            if (null != libraryManage)
            {
                conn = libraryManage.conn;
            }
        }
    }
}
