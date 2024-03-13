using Homeworks_Exception.Services;
using Homeworks_Exception.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Controllers
{
    internal class BookController
    {
        private readonly IBookService _bookService;

        public BookController()
        {
            _bookService = new BookService();
        }

        public int SearchCount()
        {
            int count = 0;

            count = (_bookService.SearchCount(book => book.Author == "Nizami Gencevi"));

            return count;

            Console.WriteLine(count); 

        }
    }
}
