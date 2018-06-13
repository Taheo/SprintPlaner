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
    public class UserController : Controller
    {
        private IUserService service = new EFUserService();
        private DataContext db = new DataContext();

        // GET: User
        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var userExists = db.ListOfUsers.SingleOrDefault(x => x.Email == user.Email);

            if (userExists != null)
            {
                Session["loginSuccess"] = true;
                Session["user"] = user.Email;
                return RedirectToAction("Dashboard", "User");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Session["loginSuccess"] = null;
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }

       
        public ActionResult Dashboard(User user)
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            string eMail = Session["user"].ToString();
            User currentUser = db.ListOfUsers.Where(x => x.Email == eMail).FirstOrDefault();
            ViewBag.User = currentUser;


            ViewBag.ListofQuests = db.ListOfQuests;
            if (currentUser.ProjectRole == Models.User.Role.Developer)
            {
                return View("DeveloperView");
            }
            if (currentUser.ProjectRole == Models.User.Role.ScrumMaster)
            {
                return View("ScrumMasterView");
            }
            if (currentUser.ProjectRole == Models.User.Role.ProductOwner)
            {
                return View("ProductOwnerView");
            }

            return View("OtherUserView");
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User newuser)
        {
            try
            {
                service.Create(newuser);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
