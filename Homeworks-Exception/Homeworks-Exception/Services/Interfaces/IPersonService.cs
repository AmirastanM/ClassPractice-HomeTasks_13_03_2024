using Homeworks_Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Services.Interfaces
{
    internal interface IPersonService 
    {
        List<Person> Search(Predicate<Person> expression);
    }
}
