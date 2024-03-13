using Homeworks_Exception.Services;
using Homeworks_Exception.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }


        public void SearchBySalary()
        {
            var response = _personService.Search(m => m.Salary >= 1000);

            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address + "-" + item.Salary);
            }
        }
    }
}
