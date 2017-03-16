using System;
using System.Data;
using System.Data.Common;

namespace ClassLibrary
{
    //数据库操作接口
    public interface DataBaseConn
    {
        //打开数据库
        void open();
        //关闭数据库
        void close();
        //执行非查询语句
        int execNonSQL(String sql);
        //执行查询语句
        DbDataReader execReader(String sql);
        //获取第一行第一列的值
        object execScalar(String sql);
        //获取连接状态
        ConnectionState getState();
        //获取连接字符串
        String getConnString();
        //获取错误信息
        String getErrorString();
        int getErrorCode();
    }
}
