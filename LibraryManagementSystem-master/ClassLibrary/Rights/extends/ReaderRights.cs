using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ReaderRights : Rights
    {
        public ReaderRights(LibraryManage lm)
            : base(lm)
        {
        }
        public List<Reader> getReaderList()
        {
            List<Reader> list = new List<Reader>();
            String sql = String.Format("select Id, Code, Name, Sex, Phone, Email, RegDate, CateId, IsBorrow from Readers;");
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        Reader ri = new Reader();
                        ri.Id = Convert.ToInt32(reader[0]);
                        ri.Code = reader[1].ToString();
                        ri.Name = reader[2].ToString();
                        ri.Sex = reader[3].ToString();
                        ri.Phone = reader[4].ToString();
                        ri.Email = reader[5].ToString();
                        ri.RegDate = Convert.ToDateTime(reader[6]);
                        ri.Cate = getReaderCate(Convert.ToInt32(reader[7]));
                        ri.IsBorrow = Convert.ToBoolean(reader[8]);
                        list.Add(ri);
                    }
                }
            }
            catch (DbException)
            {
                //日志
            }

            return list;
        }
        public List<ReaderCate> getReaderCateList()
        {
            List<ReaderCate> list = new List<ReaderCate>();
            String sql = String.Format("select " +
                "Id,Name,LimitBooksCount,LimitDays,ReBorrowTimes,ReBorrowDays,Discount " +
                "from ReaderCate"
                );
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        ReaderCate rc = new ReaderCate();
                        rc.Id = Convert.ToInt32(reader[0]);
                        rc.Name = reader[1].ToString();
                        rc.LimitBooksCount = Convert.ToInt32(reader[2]);
                        rc.LimitDays = Convert.ToInt32(reader[3]);
                        rc.ReBorrowTimes = Convert.ToInt32(reader[4]);
                        rc.ReBorrowDays = Convert.ToInt32(reader[5]);
                        rc.Discount = Convert.ToDouble(reader[6]);
                        list.Add(rc);
                    }
                }
            }
            catch (DbException)
            {

            }

            return list;
        }

        public ReaderCate getReaderCate(int cateId)
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
        public bool upReader(Reader reader)
        {
            String sql = String.Format("Update Readers set Name='{0}',Sex='{1}',Phone='{2}',Email = '{3}',CateId={4},IsBorrow={6} " +
                   "where Code = '{5}'",
                   reader.Name, reader.Sex, reader.Phone, reader.Email,
                   reader.Cate.Id, reader.Code, reader.IsBorrow ? 1 : 0);
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
        public bool addReader(Reader reader)
        {
            String sql = String.Format("insert into Readers values(null,'{0}','','{1}','{2}','{3}','{4}',Date('now','+8 hour'),{5},{6})",
                    reader.Code, reader.Name, reader.Sex, reader.Phone, 
                    reader.Email, reader.Cate.Id, reader.IsBorrow ? 1 : 0);
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
        public bool delReader(Reader reader)
        {
            String sql = String.Format("delete from Readers where Id='{0}'",
                    reader.Id);
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
        public int getReaderBorrowCount(Reader reader)
        {
            int ret = 0;
            String sql = String.Format("Select count(*) from BorrowRecord where IsReturn =0 and ReaderId = {0}", reader.Id);
            try
            {
                ret = int.Parse(conn.execScalar(sql).ToString());
            }
            catch (DbException)
            {
                ret = -1;
            }
            return ret;
        }
        public List<Reader> findReader(String attr, String value)
        {
            List<Reader> list = new List<Reader>();
            String sql = String.Format("select Id, Code, Name, Sex, Phone, Email, RegDate, CateId, IsBorrow from Readers where {0} like '%{1}%'", 
                attr, value);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        Reader ri = new Reader();
                        ri.Id = Convert.ToInt32(reader[0]);
                        ri.Code = reader[1].ToString();
                        ri.Name = reader[2].ToString();
                        ri.Sex = reader[3].ToString();
                        ri.Phone = reader[4].ToString();
                        ri.Email = reader[5].ToString();
                        ri.RegDate = Convert.ToDateTime(reader[6]);
                        ri.Cate = getReaderCate(Convert.ToInt32(reader[7]));
                        ri.IsBorrow = Convert.ToBoolean(reader[8]);
                        list.Add(ri);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }

        public bool upReaderCate(ReaderCate cate)
        {
            String sql = String.Format("Update ReaderCate set Name='{0}'," +
                    "LimitBooksCount={1},LimitDays = {2},ReBorrowTimes={3},ReBorrowDays ={4},Discount = {6} " +
                    "where Id={5}",
                    cate.Name, cate.LimitBooksCount, cate.LimitDays, cate.ReBorrowTimes, cate.ReBorrowDays,cate.Id,cate.Discount);
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
        public bool addReaderCate(ReaderCate cate)
        {
            String sql = String.Format("insert into ReaderCate values(null,'{0}',{1},{2},{3},{4},{5})",
                    cate.Name, cate.LimitBooksCount, cate.LimitDays, cate.ReBorrowTimes, cate.ReBorrowDays,cate.Discount);
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
        public bool delReaderCate(ReaderCate cate)
        {
            String sql = String.Format("delete from ReaderCate where Id='{0}'", cate.Id);
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
        public int getReaderCateCount(ReaderCate cate)
        {
            int ret = 0;
            String sql = String.Format("Select count(*) from Readers where CateId = {0}", cate.Id);
            try
            {
                ret = int.Parse(conn.execScalar(sql).ToString());
            }
            catch (DbException)
            {
                ret = -1;
            }
            return ret;
        }
        public List<ReaderCate> findReaderCate(String attr, String value)
        {
            List<ReaderCate> list = new List<ReaderCate>();
            String sql = String.Format("select Id, Name, LimitBooksCount, LimitDays, ReBorrowTimes, ReBorrowDays from ReaderCate where {0} like '%{1}%'",
                attr, value);
            try
            {
                using (DbDataReader reader = conn.execReader(sql))
                {
                    while (reader.Read())
                    {
                        ReaderCate rc = new ReaderCate();
                        rc.Id = Convert.ToInt32(reader[0]);
                        rc.Name = reader[1].ToString();
                        rc.LimitBooksCount = Convert.ToInt32(reader[2]);
                        rc.LimitDays = Convert.ToInt32(reader[3]);
                        rc.ReBorrowTimes = Convert.ToInt32(reader[4]);
                        rc.ReBorrowDays = Convert.ToInt32(reader[5]);
                        rc.Discount = Convert.ToDouble(reader[6]);
                        list.Add(rc);
                    }
                }
            }
            catch (DbException)
            {
                //输出日志
            }
            return list;
        }
    }
}

