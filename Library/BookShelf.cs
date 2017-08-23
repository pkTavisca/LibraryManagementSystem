using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BookShelf
    {
        private List<IBook> _books;

        public BookShelf(List<IBook> books)
        {
            _books = books ?? new List<IBook>();
        }

        public bool IsBookPresent(IBook book)
        {
            foreach (var bookInShelf in _books)
            {
                if (bookInShelf.Id == book.Id) return true;
            }
            return false;
        }

        public void TakeOut(IBook book)
        {
            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].Id == book.Id)
                {
                    _books.RemoveAt(i);
                    break;
                }
            }
        }

        public List<IBook> GetAllBooks()
        {
            return _books;
        }
    }
}
