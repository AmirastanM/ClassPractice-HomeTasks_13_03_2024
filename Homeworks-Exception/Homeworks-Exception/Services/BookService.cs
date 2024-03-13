using Homeworks_Exception.Data;
using Homeworks_Exception.Models;
using Homeworks_Exception.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Services
{
    internal class BookService : IBookService

    {
        public int SearchCount(Func<Book, bool> predicate)
        {
            return AppDbContextBooks.books.Count(predicate);
        }
    }
}
