using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Book
    {
        public int Id;
        public string ISBN;
        public string Name;
        public string Author;
        public BookCate bookCate;
        public string Publisher;
        public string PublishDate;
        public decimal Price;
        public string KeyWords;
        public string Language;
        public decimal TotalCount;
        public User Operator;
        public String FullBookCate;
        public bool IsBorrow;
    }
}
