using System;
using System.Collections.Generic;
using Library.Contracts;
using Library.Constants;
using Library.Models;
using Library;
using Xunit;

namespace LibraryFixture
{
    public class LibrarianFixture
    {
        [Fact]
        public void Issuing_a_book()
        {
            List<IBook> books = new List<IBook>();
            var book = new Book(1, "qw", Genre.Adventure);
            books.Add(book);
            BookShelf shelf = new BookShelf(books);
            Librarian librarian = new Librarian(shelf);

            librarian.IssueBook(book);
            Assert.Equal(book.ToString(), librarian.GetAllIssuedBooks().Trim('\n'));
        }
    }
}
