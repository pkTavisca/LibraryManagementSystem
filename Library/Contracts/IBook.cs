using Library.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contracts
{
    public interface IBook
    {
        int Id { get; }
        string Name { get; }
        Genre Genre { get; }
    }
}
