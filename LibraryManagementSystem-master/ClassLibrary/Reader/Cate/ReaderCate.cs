using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public partial class ReaderCate
    {
        public int Id;
        public string Name;
        public int LimitBooksCount;
        public int LimitDays;
        public int ReBorrowTimes;
        public int ReBorrowDays;
        public double Discount;

        public ReaderCate()
        {

        }
    }
}
