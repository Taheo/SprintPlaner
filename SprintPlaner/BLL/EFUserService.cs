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
            using (var db = new DataContext())
            {
                db.ListOfUsers.Add(user);
                db.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using (var db = new DataContext())
            {
                var userToDelete = db.ListOfUsers.Where(x => x.Id == id).FirstOrDefault();
                db.ListOfUsers.Remove(userToDelete);
                db.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var db = new DataContext())
            {
                return db.ListOfUsers.ToList();
            }
        }

        public User GetByID(Guid id)
        {
            using (var db = new DataContext())
            {
                return db.ListOfUsers.SingleOrDefault(x => x.Id == id);
            }
        }
    }
}