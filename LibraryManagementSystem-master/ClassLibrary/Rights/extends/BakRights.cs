
using System;
using System.IO;
using System.Windows.Forms;
namespace ClassLibrary
{
    public class BakRights : Rights
    {
        public BakRights(LibraryManage lm)
            : base(lm)
        {
        }

        /// <summary>
        /// 备份数据文件
        /// </summary>
        /// <param name="dest">要备份到的目录</param>
        /// <returns></returns>
        public bool bakDb(String dest)
        {
            //Library 是数据库默认名字
            dest = dest + "\\" +
                   "Library" +
                   DateTime.Now.Year.ToString("d4") +
                   DateTime.Now.Month.ToString("d2") +
                   DateTime.Now.Day.ToString("d2") +
                   DateTime.Now.Hour.ToString("d2") +
                   DateTime.Now.Minute.ToString("d2") +
                   DateTime.Now.Second.ToString("d2") + ".dbbak";
            File.Copy(libraryManage.getDbPath(),dest,true); //复制文件
            if(File.Exists(dest))
            {
                return true;
            }
            return false;
        }

        public bool RecoverFile(String source,bool copyToCurr)
        {
            if (libraryManage.isDb(source))
            {
                if (copyToCurr)
                {
                    int index = source.LastIndexOf("\\");
                    //-6是减去.dbbak的长度，-1是因为要从 \ 的下一个字符开始取，所以再-1，一共 -7 
                    //String dbPath = Application.StartupPath + source.Substring(index, source.Length - index - 6) + "." +libraryManage.getDbSuffix();
                    String dbPath = source.Substring(index + 1, source.Length - index - 7) + "." + libraryManage.getDbSuffix();
                    File.Copy(source, dbPath, true); //复制文件到当前目录下
                    libraryManage.setDbPath(dbPath);
                    libraryManage.ReConn();
                    return true;
                }
                //String dbPath = Application.StartupPath + "\\" + source.Substring(index, source.Length - index - 6) + "." + libraryManage.getDbSuffix();
                libraryManage.setDbPath(source);
                libraryManage.ReConn();
                return true;
            }
            return false;
        }
    }
}
