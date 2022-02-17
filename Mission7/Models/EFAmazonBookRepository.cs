using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class EFAmazonBookRepository : IAmazonBookRepository
    {
        private AmazonBookContext context { get; set; }

        public EFAmazonBookRepository (AmazonBookContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
