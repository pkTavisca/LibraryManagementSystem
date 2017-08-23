using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class IssuedBooks
    {
        private List<IBook> _books;

        public IssuedBooks()
        {
            _books = new List<IBook>();
        }

        public void Add(IBook book)
        {
            _books.Add(book);
        }

        public List<IBook> GetAllBooks()
        {
            return _books;
        }
    }
}
