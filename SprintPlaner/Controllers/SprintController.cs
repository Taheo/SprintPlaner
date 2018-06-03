using SprintPlaner.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SprintPlaner.Controllers
{
    public class SprintController : Controller
    {
        private ISprintService service = new EFSprintService();
        // GET: Sprint
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sprint/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sprint/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sprint/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sprint/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sprint/Edit/5
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

        // GET: Sprint/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sprint/Delete/5
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
