using System;
using System.Collections.Generic;
using Library.Contracts;
using Library.Constants;
using Library.Models;
using Library;
using Xunit;

namespace LibraryFixture
{
    public class BookShelfFixture
    {
        [Fact]
        public void Inititalizing_bookShelf()
        {
            List<IBook> books = new List<IBook>();
            books.Add(new Book(1, "qw", Genre.Adventure));
            BookShelf shelf = new BookShelf(books);
            Assert.Equal(1, shelf.GetAllBooks()[0].Id);
        }

        [Fact]
        public void Check_if_book_present()
        {
            List<IBook> books = new List<IBook>();
            var book = new Book(1, "qw", Genre.Adventure);
            books.Add(book);
            BookShelf shelf = new BookShelf(books);
            Assert.True(shelf.IsBookPresent(book));
        }

        [Fact]
        public void Check_if_wrong_book_not_present()
        {
            List<IBook> books = new List<IBook>();
            var book = new Book(1, "qw", Genre.Adventure);
            BookShelf shelf = new BookShelf(books);
            Assert.False(shelf.IsBookPresent(book));
        }

        [Fact]
        public void Check_if_taking_out_a_book_removes_it_from_shelf()
        {
            List<IBook> books = new List<IBook>();
            var book = new Book(1, "qw", Genre.Adventure);
            books.Add(book);
            BookShelf shelf = new BookShelf(books);

            //Taking Out
            shelf.TakeOut(book);
            Assert.False(shelf.IsBookPresent(book));
        }
    }
}
