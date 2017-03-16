using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public partial class BookCate
    {
        public BookCate prev = null;
        public int Id;
        public int ParentId;
        public String Name;
        public BookCate next = null;

        //暂时没有用到
        public String getFullPahtForId()
        {
            String path = Id.ToString();
            BookCate temp = this.next;
            while (null != temp)
            {
                path += temp.Id.ToString();
                temp = temp.next;
            }
            return path;
        }
        public String getFullPahtForName()
        {
            String path = Name;
            BookCate temp = this.next;
            while (null != temp)
            {
                path += "\\" + temp.Name;
                temp = temp.next;
            }
            return path;
        }
        
    }
}
