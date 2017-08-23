using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BookShelf
    {
        public List<IBook> books { get; set; }

        public BookShelf()
        {
            books = new List<IBook>();
        }
    }
}
