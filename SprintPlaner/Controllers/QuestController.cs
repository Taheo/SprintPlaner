using SprintPlaner.BLL;
using SprintPlaner.DataBase;
using SprintPlaner.Models;
using SprintPlaner.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SprintPlaner.Controllers
{
    public class QuestController : Controller
    {
        private IQuestService service = new EFQuestService();
        private DataContext db = new DataContext();
        // GET: Quest
        public ActionResult Index()
        {
            return View();
        }

        // GET: Quest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quest newquest)
        {
            try
            {
                service.Create(newquest);
                //return View();
                return RedirectToAction("Dashboard", "User");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateQuest(CreateQuestVM model)
        {
            if (ModelState.IsValid)
            {
                Quest quest = new Quest()
                {
                    Title = model.Title,
                    Description = model.Description,
                    StoryValue = model.StoryValue
                };

                service.Create(quest);
            }

            return RedirectToAction("Dashboard", "User");
        }

        // GET: Quest/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Quest/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, QuestToEditVM questtoedit)
        {
            try
            {
                var QuestNew = new Quest
                {
                    Id = questtoedit.ID,
                    Title = questtoedit.Title,
                    Description = questtoedit.Description,
                    Note = questtoedit.Note,
                    StoryValue = questtoedit.StoryValue
                };
                service.Edit(id, QuestNew);

                return RedirectToAction("Dashboard", "User");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Update(Guid id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Guid id, QuestForDevVM questtoedit)
        {
            try
            {
               
                service.Update(id, questtoedit);

                return RedirectToAction("Dashboard", "User");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AssignToSprint(Guid id)
        {
            var questToChange = db.ListOfQuests.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                questToChange.StatusInSprint = true;
                db.SaveChanges();
                return RedirectToAction("Dashboard", "User");
            }
            catch 
            {

                return RedirectToAction("Dashboard","User");
            }
        }

        // GET: Quest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quest/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
