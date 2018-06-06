using SprintPlaner.BLL;
using SprintPlaner.DataBase;
using SprintPlaner.Models;
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
                return View();
                //return RedirectToAction("Dashboard", "User");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quest/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
