using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    //备份管理类
    public class BakManage : Manage
    {
        public BakManage(LibraryManage lm) : base(lm)
        {
        }
        public bool bakDb(String dest)
        {
            bool ret = user.bakRights.bakDb(dest);
            if(true == ret){
                String val = "备份到：" + dest;
                log.write("备份数据", val, user.code);
            }
            return ret;
        }
        public bool RecoverFile(String source,bool copyToCurr)
        {
            bool ret = user.bakRights.RecoverFile(source, copyToCurr);
            if (true == ret)
            {
                String val = "恢复到：" + source + " 当前：" + copyToCurr.ToString();
                log.write("恢复数据", val, user.code);
            }
            return ret;
        }
    }
}
