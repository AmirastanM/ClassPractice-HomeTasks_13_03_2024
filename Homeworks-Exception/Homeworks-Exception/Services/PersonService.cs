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
    internal class PersonService : IPersonService
    {
        public List<Person> Search(Predicate<Person> expression)
        {
            List<Person> list = new List<Person>(); 

            foreach( var item in AppDbContextPersons.persons)
            {
                if (expression(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
