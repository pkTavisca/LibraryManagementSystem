using System;
using System.Collections.Generic;
using Library.Contracts;
using Library.Constants;
using Library.Models;
using Library;
using Xunit;

namespace LibraryFixture
{
    public class IssuedBooksFixture
    {
        [Fact]
        public void Checking_inititalization_of_issued_books()
        {
            IssuedBooks books = new IssuedBooks();
            Assert.Equal(0, books.GetAllBooks().Count);
        }

        [Fact]
        public void Issuing_a_book()
        {
            IssuedBooks books = new IssuedBooks();
            var book = new Book(1, "qw", Genre.Adventure);
            books.Add(book);
            Assert.Equal(1, books.GetAllBooks().Count);
        }
    }
}
