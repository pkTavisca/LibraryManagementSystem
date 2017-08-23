using System;
using Xunit;
using Library.Models;
using Library.Constants;

namespace LibraryFixture
{
    public class BookFixture
    {
        [Fact]
        public void Validating_toString_method_of_book()
        {
            Book book = new Book(1, "Book1", Genre.Adventure);
            Assert.Equal("1: Book1 - Adventure", book.ToString());
        }
    }
}
