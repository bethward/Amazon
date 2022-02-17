using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission7.Models
{
    public interface IAmazonBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
