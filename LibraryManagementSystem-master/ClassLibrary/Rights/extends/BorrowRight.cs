using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class BorrowRights : Rights
    {
        public BorrowRights(LibraryManage lm)
            : base(lm)
        {
        }

        public List<Borrow> getBorrowList(String bookAttr, String bookvalue, String readerAttr, String readervalue)
        {
            List<Borrow> list = new List<Borrow>();
            String sql = String.Format("select " +
               "*" +
               " from [View_Borrow] where IsReturn = 0 and {0} like '%{1}%' and {2} like '%{3}%'", bookAttr, bookvalue, readerAttr, readervalue);
            using (DbDataReader reader = conn.execReader(sql))
            {
                while (reader.Read())
                {
                    Borrow b = new Borrow();
                    b.Id = Convert.ToInt32(reader[0]);
                    b.ISBN = reader[1].ToString();
                    b.BookName = reader[2].ToString();
                    b.ReaderCode = reader[3].ToString();
                    b.ReaderName = reader[4].ToString();
                    b.ReaderCateId = Convert.ToInt32(reader[5]);
                    b.Date = Convert.ToDateTime(reader[6]);
                    b.ReturnDate = Convert.ToDateTime(reader[7]);
                    b.ReBorrowTimes = Convert.ToInt32(reader[8]);
                    b.IsReturn = Convert.ToBoolean(reader[9]);
                    b.BorrowOperator = reader[10].ToString();
                    b.ReturnOperator = reader[11].ToString();
                    list.Add(b);
                }
            }
            return list;
        }
        public List<Borrow> getBorrowList()
        {
            List<Borrow> list = new List<Borrow>();
            String sql = String.Format("select * from [View_Borrow];");
            using (DbDataReader reader = conn.execReader(sql))
            {
                while (reader.Read())
                {
                    Borrow b = new Borrow();
                    b.Id = Convert.ToInt32(reader[0]);
                    b.ISBN = reader[1].ToString();
                    b.BookName = reader[2].ToString();
                    b.ReaderCode = reader[3].ToString();
                    b.ReaderName = reader[4].ToString();
                    b.ReaderCateId = Convert.ToInt32(reader[5]);
                    b.Date = Convert.ToDateTime(reader[6]);
                    b.ReturnDate = Convert.ToDateTime(reader[7]);
                    b.ReBorrowTimes = Convert.ToInt32(reader[8]);
                    b.IsReturn = Convert.ToBoolean(reader[9]);
                    b.BorrowOperator = reader[10].ToString();
                    b.ReturnOperator = reader[11].ToString();
                    list.Add(b);
                }
            }
            return list;
        }

        public Book getBook(String ISBN)
        {
            Book b = null;
            String sql = String.Format("select " +
               "Id , ISBN , Name ,Author , BookCate , Publisher ," +
               "PublishDate , Price , KeyWords , Language, " +
               "TotalCount, Operator,FullBookCate, IsBorrow" +
               " from Books where ISBN = '{0}'", ISBN);

            using (DbDataReader reader = conn.execReader(sql))
            {
                while (reader.Read())
                {
                    b = new Book();
                    b.Id = Convert.ToInt32(reader[0]);
                    b.ISBN = reader[1].ToString();
                    b.Name = reader[2].ToString();
                    b.Author = reader[3].ToString();
                    b.bookCate = null;
                    b.Publisher = reader[5].ToString();
                    b.PublishDate = reader[6].ToString();
                    b.Price = Convert.ToDecimal(reader[7]);
                    b.KeyWords = reader[8].ToString();
                    b.Language = reader[9].ToString();
                    b.TotalCount = Convert.ToDecimal(reader[10]);
                    String tmp = reader[11].ToString();
                    b.Operator = null;
                    b.FullBookCate = reader[12].ToString();
                    b.IsBorrow = Convert.ToBoolean(reader[13]);
                }
            }
            return b;
        }
        public Reader getReader(String Code)
        {
            Reader ri = null;
            String sql = String.Format("select Id, Code, Name, Sex, Phone, Email, RegDate, CateId, IsBorrow from Readers where Code = '{0}';", Code);
            using (DbDataReader reader = conn.execReader(sql))
            {
                if (reader.Read())
                {
                    ri = new Reader();
                    ri.Id = Convert.ToInt32(reader[0]);
                    ri.Code = reader[1].ToString();
                    ri.Name = reader[2].ToString();
                    ri.Sex = reader[3].ToString();
                    ri.Phone = reader[4].ToString();
                    ri.Email = reader[5].ToString();
                    ri.RegDate = Convert.ToDateTime(reader[6]);
                    ri.Cate = getReaderCate(Convert.ToInt32(reader[7]));
                    ri.IsBorrow = Convert.ToBoolean(reader[8]);
                }
            }

            return ri;
        }
        private ReaderCate getReaderCate(int cateId)
        {
            String sql = String.Format("select " +
            "Id,Name,LimitBooksCount,LimitDays,ReBorrowTimes,ReBorrowDays,Discount " +
            "from ReaderCate where Id = {0}",
            cateId);

            DbDataReader reader = conn.execReader(sql);
            ReaderCate rc = new ReaderCate();
            if (reader.Read())
            {
                rc.Id = Convert.ToInt32(reader[0]);
                rc.Name = reader[1].ToString();
                rc.LimitBooksCount = Convert.ToInt32(reader[2]);
                rc.LimitDays = Convert.ToInt32(reader[3]);
                rc.ReBorrowTimes = Convert.ToInt32(reader[4]);
                rc.ReBorrowDays = Convert.ToInt32(reader[5]);
                rc.Discount = Convert.ToDouble(reader[6]);
            }
            return rc;
        }

        public bool addDays(Borrow b)
        {
            int ret = 0;
            DateTime ReturnDate = b.ReturnDate;
            int days = getReaderCate(b.ReaderCateId).ReBorrowDays;
            ReturnDate = ReturnDate.AddDays(days);
            String sql = string.Format("Update BorrowRecord set ReBorrowTimes = ReBorrowTimes-1,ReturnDate = '{1}' where Id ={0}",
            b.Id, ReturnDate.ToString("yyyy-MM-dd"));

            ret = conn.execNonSQL(sql);
            if (ret == 1)
            {
                return true;
            }
            return false;
        }
        public bool returnBook(Borrow b,User u)
        {
            int ret = 0;
            String sql = string.Format("Update BorrowRecord set IsReturn = 1,ReturnOperator='{1}' where Id ={0}",
           b.Id, u.code);

            ret = conn.execNonSQL(sql);
            if (ret == 1)
            {
                return true;
            }
            return false;
        }
        public bool addBorrow(Book b,Reader r, User u)
        {
            int ret = 0;
            ReaderCate rc = r.Cate;
            DateTime ReturnDate = DateTime.Now;
            ReturnDate = ReturnDate.AddDays(rc.LimitDays);
            String sql = String.Format("insert into BorrowRecord " +
                "values(null, '{0}', '{1}', Date('now','+8 hour'), '{2}', 0, {3}, '{4}', null)",
                b.Id, 
                r.Id, 
                ReturnDate.ToString("yyyy-MM-dd"), 
                rc.ReBorrowTimes, 
                u.id);
            ret = conn.execNonSQL(sql);
            if (ret == 1)
            {
                return true;
            }

            return false;
        }

        public int getReaderBorrowCount(Reader r)
        {
            int ret = 0;
            String sql = String.Format("Select count(*) from BorrowRecord where ReaderId = {0}", r.Code);
            ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }
        public int getBookCount(Book b)
        {
            int ret = 0;
            String sql = String.Format("Select TotalCount from Books where Id = {0}", b.Id);
            ret = Convert.ToInt32(conn.execScalar(sql));
            return ret;
        }

        public bool subBookCount(Book b)
        {
            int ret = 0;
            String sql = String.Format("Update Books set TotalCount = TotalCount - 1 " +
                "where Id = '{0}'",
                b.Id);
            ret = conn.execNonSQL(sql);
            if (ret == 1)
            {
                return true;
            }
            return false;
        }
        public bool addBookCount(Book b)
        {
            int ret = 0;
            String sql = String.Format("Update Books set TotalCount = TotalCount +1 " +
                "where Id = '{0}'",
                b.Id);
            ret = conn.execNonSQL(sql);
            if (ret == 1)
            {
                return true;
            }

            return false;
        }
    }
}
