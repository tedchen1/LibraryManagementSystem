using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibrary
{
    [SQLiteFunction(Name = "REGEXP", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class REGEXP : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            //下标0代表表达式后面的值，1代表表达式前面的值 
            //例 Code REGEXP('A')
            // 0 A 1 Code中的值
            return Regex.IsMatch(args[1].ToString(), args[0].ToString());
        }
    }
}
