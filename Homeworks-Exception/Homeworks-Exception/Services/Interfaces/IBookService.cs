using Homeworks_Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Services.Interfaces
{
    internal interface IBookService
    {
       public int SearchCount(Func<Book, bool> predicate);
    }
}
