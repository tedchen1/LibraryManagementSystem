using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class BookRights : Rights
    {
        public BookRights(LibraryManage lm)
            : base(lm)
        {
        }

        public List<Book> getBookList(String attr, String value)
        {
            List<Book> list = new List<Book>();
            String sql = String.Format("select " +
               "Id , ISBN , Name ,Author , BookCate , Publisher ," +
               "PublishDate , Price , KeyWords , Language, " +
               "TotalCount, Operator,FullBookCate, IsBorrow" +
               " from Books where {0} like '%{1}%'", attr, value);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        Book b = new Book();
                        b.Id = Convert.ToInt32(reader[0]);
                        b.ISBN = reader[1].ToString();
                        b.Name = reader[2].ToString();
                        b.Author = reader[3].ToString();
                        //b.bookCate = makeBookCateTree(reader[4].ToString());
                        b.bookCate = getBookCate(Convert.ToInt32(reader[4]));
                        b.Publisher = reader[5].ToString();
                        b.PublishDate = reader[6].ToString();
                        b.Price = Convert.ToDecimal(reader[7]);
                        b.KeyWords = reader[8].ToString();
                        b.Language = reader[9].ToString();
                        b.TotalCount = Convert.ToDecimal(reader[10]);
                        String tmp = reader[11].ToString();
                        b.Operator = getUser(Convert.ToInt32(tmp));
                        b.FullBookCate = reader[12].ToString();
                        b.IsBorrow = Convert.ToBoolean(reader[13]);
                        list.Add(b);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
        public List<Book> getBookListForREGEXP(String cateId)
        {
            List<Book> list = new List<Book>();
            //REGEXP 是自定义函数，具体实现看 REGEXP 类
            String sql = String.Format("select " +
               "Id , ISBN , Name ,Author , BookCate , Publisher ," +
               "PublishDate , Price , KeyWords , Language, " +
               "TotalCount, Operator,FullBookCate, IsBorrow" +
               " from Books where FullBookCate REGEXP '\\[{0}\\]'", cateId);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        Book b = new Book();
                        b.Id = Convert.ToInt32(reader[0]);
                        b.ISBN = reader[1].ToString();
                        b.Name = reader[2].ToString();
                        b.Author = reader[3].ToString();
                        //b.bookCate = makeBookCateTree(reader[4].ToString());
                        b.bookCate = getBookCate(Convert.ToInt32(reader[4]));
                        b.Publisher = reader[5].ToString();
                        b.PublishDate = reader[6].ToString();
                        b.Price = Convert.ToDecimal(reader[7]);
                        b.KeyWords = reader[8].ToString();
                        b.Language = reader[9].ToString();
                        b.TotalCount = Convert.ToDecimal(reader[10]);
                        String tmp = reader[11].ToString();
                        b.Operator = getUser(Convert.ToInt32(tmp));
                        b.FullBookCate = reader[12].ToString();
                        b.IsBorrow = Convert.ToBoolean(reader[13]);
                        list.Add(b);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
        public List<BookCate> getBookCateList(int Id)
        {
            List<BookCate> list = new List<BookCate>();
            String sql = String.Format("select * from BookCate where ParentId = {0};", Id);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        BookCate bc = new BookCate();
                        bc.Id = Convert.ToInt32(reader[0]);
                        bc.ParentId = Convert.ToInt32(reader[1]);
                        bc.Name = reader[2].ToString();
                        list.Add(bc);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }

        public BookCate makeBookCateTree(String cateIds) 
        {
            //双向链表
            BookCate Cate = getBookCate(Convert.ToInt32(cateIds[0]));
            BookCate temp = null;
            BookCate prev = null;
            temp = Cate;

            for (int i = 1; i < cateIds.Length; i++)
            {
                temp.next = getBookCate(Convert.ToInt32(cateIds[i]));
                temp.next.prev = temp;
                prev = temp;
                temp = temp.next;
            }

            return Cate;
        }
        public BookCate getBookCate(int cateId)
        {
            BookCate cate = new BookCate();
            String sql = String.Format("SELECT * FROM BookCate " +
            "where Id = {0}", cateId);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    if (reader.Read())
                    {
                        cate.Id = Convert.ToInt32(reader[0]);
                        cate.ParentId = Convert.ToInt32(reader[1]);
                        cate.Name = reader[2].ToString();
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return cate;
        }
        public List<BookCate> getBookCateList(String name)
        {
            List<BookCate> list = new List<BookCate>();
            String sql = String.Format("select Id, ParentId, Name from BookCate where Name like '%{0}%';", name);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        BookCate bc = new BookCate();
                        bc.Id = Convert.ToInt32(reader[0]);
                        bc.ParentId = Convert.ToInt32(reader[1]);
                        bc.Name = reader[2].ToString();
                        list.Add(bc);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }

        private User getUser(int Id)
        {
            User u = new User();
            String sql = String.Format("select " +
               "Id , Code , Name , IsLock , IsUserRight , IsBookRight ," +
               "IsReaderRight , IsBorrowRight , IsLogRight , IsBakRight " +
               "from Users where Id = {0}", Id);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    if (reader.Read())
                    {
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
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return u;
        }

        public bool addBook(Book b)
        {
            String sql = String.Format("insert into Books values(null,'{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}',{9},'{10}','{11}',{12})",
                    b.ISBN, b.Name, b.Author, b.bookCate.Id, b.Publisher, b.PublishDate, b.Price, b.KeyWords,
                    b.Language, b.TotalCount, b.Operator.id, b.FullBookCate, b.IsBorrow ? 1 : 0);
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
        public bool upBook(Book b)
        {
            String sql = String.Format("Update Books set ISBN='{0}',Name='{1}',Author='{2}',BookCate = '{3}',Publisher='{4}',PublishDate='{5}',Price={6},KeyWords='{7}',Language='{8}',TotalCount = '{9}',FullBookCate='{10}',IsBorrow = {11} " +
                    "where Id = {12}",
                    b.ISBN, b.Name, b.Author, b.bookCate.Id, b.Publisher, b.PublishDate, b.Price, b.KeyWords, b.Language, b.TotalCount, b.FullBookCate, b.IsBorrow ? 1 : 0, b.Id);
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
        public bool delBook(Book b)
        {
            bool ret = false;
            String sql = String.Format("delete from Books where Id='{0}'",
                    b.Id);
            int row = conn.execNonSQL(sql);
            if (1 == row)
            {
                ret = true;
            }
            return ret;
        }

        public bool addBookCate(BookCate b)
        {
            String sql = String.Format("insert into BookCate values(null,{0},'{1}')",
                    b.ParentId, b.Name);
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
        public bool upBookCate(BookCate b)
        {
            String sql = String.Format("Update BookCate set Name='{0}', ParentId={1} where Id={2}",
                    b.Name, b.ParentId, b.Id);
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
        public bool upBookFullBookCate(int cateId, String path)
        {
            String sql = String.Format("Update Book set FullBookCate='{0}' where BookCate={1}",
                    path, cateId);
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
        public String getFullPath(BookCate b)
        {
            String fullPath = "";
            //0是最上级
            //fullPath = b.Name;
            BookCate tmp = b;
            while (0 != tmp.Id)
            {
                fullPath = fullPath.Insert(0, "\\" + tmp.Name);
                tmp = getBookCate(tmp.ParentId);
            }
            //fullPath.Insert(0, tmp.Name);
            return fullPath;
        }
        public bool delBookCate(BookCate b)
        {
            String sql = String.Format("delete from BookCate where Id={0}",
                    b.Id);
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

        //获得类别下子类别的数量
        public int getBookCateChildCount(int cateId)
        {
            String sql = String.Format("select count(*) from BookCate where ParentId = {0}", cateId);
            int ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }
        //获得该类别的图书数量
        public int getBookCateBookCount(int cateId)
        {
            String sql = String.Format("select count(*) from Books where BookCate = {0}", cateId);
            int ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }

        //获取该图书被借出的数量
        public int getBookBorrowCount(int id)
        {
            String sql = String.Format("select count(*) from Books where Id = {0}", id);
            int ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }
    }
}
