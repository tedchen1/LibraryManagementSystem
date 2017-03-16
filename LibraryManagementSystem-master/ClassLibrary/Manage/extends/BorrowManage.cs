using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class BorrowManage : Manage
    {
        public BorrowManage(LibraryManage lm)
            : base(lm)
        {

        }
        public List<Borrow> getBorrowList(String bookAttr, String bookvalue, String readerAttr, String readervalue)
        {
            return user.borrowRights.getBorrowList(bookAttr, bookvalue, readerAttr, readervalue);
        }
        public List<Borrow> getBorrowList()
        {
            return user.borrowRights.getBorrowList();
        }

        public bool addDays(Borrow b)
        {
            bool ret = user.borrowRights.addDays(b);
            if (true == ret)
            {
                String val = b.Id.ToString();
                log.write("续借图书", val, user.code);
            }
            return ret;
        }
        public bool returnBook(Borrow b)
        {
            bool ret = user.borrowRights.returnBook(b, user);
            if (true == ret)
            {
                String val = b.Id.ToString() + " " + user.code;
                log.write("返还图书", val, user.code);
            }
            return ret;
        }
        public bool addBorrow(Book b, Reader r)
        {
            bool ret = user.borrowRights.addBorrow(b, r, user);
            if (true == ret)
            {
                String val = b.Id.ToString() + " " + user.code;
                log.write("借阅图书", val, user.code);
            }
            return ret;
        }

        public Book getBook(String ISBN)
        {
            return user.borrowRights.getBook(ISBN);
        }
        public Reader getReader(String Code)
        {
            return user.borrowRights.getReader(Code);
        }
        /*public ReaderCate getReaderCate(int cateId)
        {
            return user.borrowRights.getReaderCate(cateId);
        }*/
        public int getReaderBorrowCount(Reader r)
        {
            return user.borrowRights.getReaderBorrowCount(r);
        }
        public int getBookCount(Book b)
        {
            return user.borrowRights.getBookCount(b);
        }

        public bool subBookCount(Book b)
        {
            return user.borrowRights.subBookCount(b);
        }
        public bool addBookCount(Book b)
        {
            return user.borrowRights.addBookCount(b);
        }
    }
}
