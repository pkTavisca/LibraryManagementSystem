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

        public bool IsBookPresent(IBook book)
        {
            foreach (var bookInShelf in books)
            {
                if (bookInShelf.Id == book.Id) return true;
            }
            return false;
        }

        public void TakeOut(IBook book)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == book.Id)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
