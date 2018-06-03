using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SprintPlaner.DataBase;
using SprintPlaner.Models;

namespace SprintPlaner.BLL
{
    public class EFSprintService : ISprintService
    {
        public void Create(Sprint sprint)
        {
            using (DataContext db = new DataContext())
            {
                db.ListOfSprints.Add(sprint);
                db.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using (DataContext db = new DataContext())
            {
                var sprintToDelete = db.ListOfSprints.Where(x => x.Id == id).FirstOrDefault();
                db.ListOfSprints.Remove(sprintToDelete);
                db.SaveChanges();
            }
        }

        public IEnumerable<Sprint> GetAll()
        {
            using (DataContext db = new DataContext())
            {
                return db.ListOfSprints;
            }
        }
        
        public Sprint GetSprintByID(Guid id)
        {
            using (DataContext db = new DataContext())
            {
                return db.ListOfSprints.SingleOrDefault(x => x.Id == id);
            }
        }
    }
}