using SprintPlaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintPlaner.BLL
{
    public class MemoryDataService : IDataService
    {
        private static readonly List<User> Users = new List<User>();

        public void Create(User user)
        {
            Users.Add(user);
        }

        public void Delete(Guid id)
        {
            Users.Remove(Users.FirstOrDefault(x => x.ID == id));
        }

        public void Edit(Guid id, User user)
        {
            Users.Remove(Users.FirstOrDefault(x => x.ID == id));
            Users.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return Users;
        }

        public User GetByID(Guid id)
        {
            return Users.FirstOrDefault(x => x.ID == id);
        }

        public User GetUserByMail(string email)
        {
            return Users.FirstOrDefault(x => x.Email == email);
        }
    }
}