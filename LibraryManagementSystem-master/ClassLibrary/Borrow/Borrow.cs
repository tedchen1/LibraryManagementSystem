using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Borrow
    {
        public int Id;
        public String ISBN;
        public String BookName;
        public String ReaderCode;
        public String ReaderName;
        public int ReaderCateId;
        public DateTime Date;
        public DateTime ReturnDate;
        public int ReBorrowTimes;
        public bool IsReturn;
        public String BorrowOperator;
        public String ReturnOperator;
    }
}
