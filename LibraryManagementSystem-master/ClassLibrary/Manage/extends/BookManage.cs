using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class BookManage : Manage
    {
        public BookManage(LibraryManage lm) : base(lm)
        {

        }
        public List<Book> getBookList(String attr, String value)
        {
            return user.bookRights.getBookList(attr, value);
        }
        public List<Book> getBookListForREGEXP(String cateId)
        {
            return user.bookRights.getBookListForREGEXP(cateId);
        }
        public List<BookCate> getBookCateList(int Id)
        {
            return user.bookRights.getBookCateList(Id);
        }
        public List<BookCate> getBookCateList(String name)
        {
            return user.bookRights.getBookCateList(name);
        }
        /*
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
        }*/
        public BookCate getBookCate(int cateId)
        {
            return user.bookRights.getBookCate(cateId);
        }

        public bool addBook(Book b)
        {
            bool ret = user.bookRights.addBook(b);
            if (true == ret)
            {
                String val = b.Name;
                log.write("新增图书", val, user.code);
            }
            return ret;
        }
        public bool upBook(Book b)
        {
            bool ret = user.bookRights.upBook(b);
            if (true == ret)
            {
                String val = b.Name;
                log.write("修改图书", val, user.code);
            }
            return ret;
        }
        public bool delBook(Book b)
        {
            bool ret = user.bookRights.delBook(b);
            if (true == ret)
            {
                String val = b.Name;
                log.write("删除图书", val, user.code);
            }
            return ret;
        }

        public bool addBookCate(BookCate b)
        {
            bool ret = user.bookRights.addBookCate(b);
            if (true == ret)
            {
                String val = b.Name;
                log.write("新增图书类别", val, user.code);
            }
            return ret;
        }
        public bool upBookCate(BookCate b)
        {
            bool ret = user.bookRights.upBookCate(b);
            if (true == ret)
            {
                String val = b.Name;
                log.write("修改图书类别", val, user.code);
            }
            return ret;
        }
        
        public String getFullPath(BookCate b)
        {
            return user.bookRights.getFullPath(b);
        }
        public bool delBookCate(BookCate b)
        {
            bool ret = user.bookRights.delBookCate(b);
            if (true == ret)
            {
                String val = b.Name;
                log.write("删除图书类别", val, user.code);
            }
            return ret;
        }
        //更新图书的FullPath信息
        public bool upBookFullBookCate(int cateId, String path)
        {
            bool ret = user.bookRights.upBookFullBookCate(cateId, path);
            if (true == ret)
            {
                String val = path;
                log.write("修改图书FullPath", val, user.code);
            }
            return ret;
        }

        //获得类别下子类别的数量
        public int getBookCateChildCount(int cateId)
        {
            return user.bookRights.getBookCateChildCount(cateId);
        }
        //获得该类别的图书数量
        public int getBookCateBookCount(int cateId)
        {
            return user.bookRights.getBookCateBookCount(cateId);
        }

        public int getBookBorrowCount(int id)
        {
            return user.bookRights.getBookBorrowCount(id);
        }
    }
}
