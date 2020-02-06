using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class BuyerController : Controller
    {
        // GET: Buyer
        public readonly BuyerContext _context;
        public BuyerController(BuyerContext context)
        {
            this._context = context;
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Buyer b)
        {


            try
            {

                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = b.BName+" successfully registered";
                return RedirectToAction("Login");

            }
            catch(Exception e)
            {

                ViewBag.message = b.BName + " registration failed";
                return View();
            }
            

        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Buyer b)
        {
            var loguser = _context.BuyerDb.Where(e => e.BName == b.BName && e.Pass == b.Pass).ToList();
            if (loguser.Count== 0)
            {
                ViewBag.Message = "not valid user";
                return View();
            }
            else
            {

                return RedirectToAction("Register");
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public bool IsExist(string email)
        {
            var result = _context.BuyerDb.Where(e => e.Email == email).ToList();
            if (result.Count==0)
                return true;
            else
                return false;
        }
        //[AcceptVerbs("Get", "Post")]
        //[AllowAnonymous]
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("email exist");
        }
    }
}