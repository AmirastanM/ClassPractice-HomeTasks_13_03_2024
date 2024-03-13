using Homeworks_Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Data
{
    internal class AppDbContextBooks
    {
        public static List<Book> books;

        static AppDbContextBooks()
        {
            books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "Sirlər xəzinəsi",
                    Author = "Nizami Gencevi"
                },
                new Book
                {
                    Id = 2,
                    Name = "Xosrov ve Shirin",
                    Author = "Nizami Gencevi"
                },
                 new Book
                {
                    Id = 3,
                    Name = "Aslan Qayasi",
                    Author = "Semed Vurgun"
                },

                 new Book
                {
                    Id = 4,
                    Name = "Leyli ve Mecnun",
                    Author = "Nizami Gencevi"
                },
                  new Book
                {
                    Id = 5,
                    Name = "Yeddi gozel",
                    Author = "Nizami Gencevi"
                },
                  new Book
                {
                    Id = 6,
                    Name = "Aygun",
                    Author = "Semed Vurgun"
                },
                  new Book
                {
                    Id = 7,
                    Name = "İsgendarname",
                    Author = "Nizami Gencevi"
                },
            };
        }

    }
}
