using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Constants;

namespace Library.Models
{
    public class Book : IBook
    {
        public int Id { get; }

        public string Name { get; }

        public Genre Genre { get; }

        public Book(int Id, string Name, Genre Genre)
        {
            this.Id = Id;
            this.Name = Name;
            this.Genre = Genre;
        }

        override public string ToString()
        {
            return $"{Id}: {Name} - {Genre.ToString()}";
        }
    }
}
