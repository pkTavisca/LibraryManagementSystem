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
            if (_bookShelf.IsBookPresent(book) == true)
            {
                _bookShelf.TakeOut(book);
                _issuedBooks.Add(book);
            }
        }

        public string GetAllIssuedBooks()
        {
            string issuedBooks = string.Empty;
            foreach (var book in _issuedBooks.GetAllBooks())
            {
                issuedBooks += book.ToString() + "\n";
            }
            return issuedBooks;
        }
    }
}
