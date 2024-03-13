using Homeworks_Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Data
{
    internal class AppDbContextPersons
    {

        public static List<Person> persons;

        static AppDbContextPersons()
        {
            persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Abdulla",
                    Surname = "Azizov",
                    Address = "28 may",
                    Salary = 700
                },
                 new Person
                {
                    Id = 2,
                    Name = "Amina",
                    Surname = "Abbasova",
                    Address = "Nerimanov",
                    Salary = 700
                },
                  new Person
                {
                    Id = 3,
                    Name = "Narmin",
                    Surname = "Alkhasova",
                    Address = "28 may",
                    Salary = 800
                },
                   new Person
                {
                    Id = 4,
                    Name = "Leyla",
                    Surname = "Qasimzade",
                    Address = "Badamdar",
                    Salary = 2500
                },
                    new Person
                {
                    Id = 5,
                    Name = "Aliyar",
                    Surname = "Tagiyev",
                    Address = "Ehmedli",
                    Salary = 1300
                },
                     new Person
                {
                    Id = 6,
                    Name = "Iskander",
                    Surname = "Iskanderov",
                    Address = "Nesimi",
                    Salary = 1000
                },
                      new Person
                {
                    Id = 7,
                    Name = "Mamed",
                    Surname = "Mamedov",
                    Address = "Ecemi",
                    Salary = 1800
                },
                       new Person
                {
                    Id = 8,
                    Name = "Seymur",
                    Surname = "Agayev",
                    Address = "Yasamal",
                    Salary = 800
                },
                        new Person
                {
                    Id = 9,
                    Name = "Akif",
                    Surname = "Azimov",
                    Address = "Xezer",
                    Salary = 300
                },
                         new Person
                {
                    Id = 10,
                    Name = "Nizami",
                    Surname = "Aliyev",
                    Address = "Sebail",
                    Salary = 2500
                },
            };
        }
    }
}
 
