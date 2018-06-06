using SprintPlaner.DataBase;
using SprintPlaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SprintPlaner.BLL
{
    public class EFQuestService : IQuestService
    {
        public void Create(Quest quest)
        {
            using (var db = new DataContext())
            {
                db.ListOfQuests.Add(quest);
                db.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using (var db = new DataContext())
            {
                var questToDelete = db.ListOfQuests.Where(x => x.Id == id).FirstOrDefault();
                db.ListOfQuests.Remove(questToDelete);
                db.SaveChanges();
            }
        }

        public IEnumerable<Quest> GetAll()
        {
            using (var db = new DataContext())
            {
                return db.ListOfQuests;
            }
        }

        public Quest GetSprintByID(Guid id)
        {
            using (var db = new DataContext())
            {
                return db.ListOfQuests.SingleOrDefault(x => x.Id == id);
            }
        }
    }
}