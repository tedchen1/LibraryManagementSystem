using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ReaderManage : Manage
    {
        public ReaderManage(LibraryManage lm)
            : base(lm)
        {
        }

        public List<Reader> getReaderList()
        {
            return user.readerRights.getReaderList();
        }
        public ReaderCate getReaderCate(int cateId)
        {
            return user.readerRights.getReaderCate(cateId);
        }
        public List<ReaderCate> getReaderCateList()
        {
            return user.readerRights.getReaderCateList();
        }
        public bool upReader(Reader reader)
        {
            bool ret = user.readerRights.upReader(reader);
            if (true == ret)
            {
                String val = reader.Code;
                log.write("修改读者", val, user.code);
            }
            return ret;
        }
        public bool addReader(Reader reader)
        {
            bool ret = user.readerRights.addReader(reader);
            if (true == ret)
            {
                String val = reader.Code;
                log.write("新增读者", val, user.code);
            }
            return ret;
        }
        public bool delReader(Reader reader)
        {
            bool ret = user.readerRights.delReader(reader);
            if (true == ret)
            {
                String val = reader.Code;
                log.write("删除读者", val, user.code);
            }
            return ret;
        }
        public int getReaderBorrowCount(Reader reader)
        {
            return user.readerRights.getReaderBorrowCount(reader);
        }
        public List<Reader> findReader(String attr, String value)
        {
            return user.readerRights.findReader(attr, value);
        }

        public bool upReaderCate(ReaderCate cate)
        {
            bool ret = user.readerRights.upReaderCate(cate);
            if (true == ret)
            {
                String val = cate.Name;
                log.write("修改读者角色", val, user.code);
            }
            return ret;
        }
        public bool addReaderCate(ReaderCate cate)
        {
            bool ret = user.readerRights.addReaderCate(cate);
            if (true == ret)
            {
                String val = cate.Name;
                log.write("新增读者角色", val, user.code);
            }
            return ret;
        }
        public bool delReaderCate(ReaderCate cate)
        {
            bool ret = user.readerRights.delReaderCate(cate);
            if (true == ret)
            {
                String val = cate.Name;
                log.write("删除读者角色", val, user.code);
            }
            return ret;
        }
        public int getReaderCateCount(ReaderCate cate)
        {
            return user.readerRights.getReaderCateCount(cate);
        }
        public List<ReaderCate> findReaderCate(String attr, String value)
        {
            return user.readerRights.findReaderCate(attr, value);
        }
    }
}
