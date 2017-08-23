using Library.Contracts;
using System;

namespace Library
{
    public class Librarian
    {
        BookShelf _bookShelf;
        IssuedBooks _issuedBooks;

        public Librarian(BookShelf bookShelf)
        {
            _bookShelf = bookShelf ?? new BookShelf();
            _issuedBooks = new IssuedBooks();
        }

        public void IssueBook(IBook book)
        {

        }
    }
}
