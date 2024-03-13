using Homeworks_Exception.Models;
using Homeworks_Exception.Services.Interfaces;
using System.Net.Sockets;

namespace Homeworks_Exception.Services
{
    internal class UserService : IUserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new() {
                    Id = 1,
                    FullName="Fatime Qayxanova",
                    Email = "fatima@code.edu.az",
                    Password = "fatime123",
                    Address = "28 May"
                },
                new() {
                    Id = 2,
                    FullName="Fexriyye Tagizade",
                    Email = "fexriyye@code.edu.az",
                    Password = "fexriyye123",
                    Address = "Nizami"
                },
                new() {
                    Id = 3,
                    FullName="Afide Veliyeva",
                    Email = "afide@code.edu.az",
                    Password = "afide123",
                    Address = "Kurdexani"
                },
            };
        }




        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
