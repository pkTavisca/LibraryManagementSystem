using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class IssuedBooks
    {
        public List<IBook> books { get; set; }

        public IssuedBooks()
        {
            books = new List<IBook>();
        }
    }
}
