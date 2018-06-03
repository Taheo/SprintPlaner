using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SprintPlaner.DataBase;
using SprintPlaner.Models;

namespace SprintPlaner.BLL
{
    public class EFUserService : IUserService
    {
        public void Create(User user)
        {
            using (DataContext db = new DataContext())
            {
                db.ListOfUsers.Add(user);
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByID(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}