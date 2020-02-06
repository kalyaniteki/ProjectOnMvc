using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class SellerController : Controller
    {
        public readonly SellerContext _context;
        public readonly IWebHostEnvironment hostingEnvironment;
        public SellerController(SellerContext context,IWebHostEnvironment hostingEnvironment)
        {
            this._context = context;
            this.hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(SellerCreatePath b)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (b.photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + b.photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    b.photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newEmployee = new Seller
                {
                   Sid=b.Sid,
                   SName=b.Sname,
                   Pass=b.Pass,
                   Email=b.Email,
                   Phno=b.Mobile,
                   date=b.date,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    Photopath = uniqueFileName
                };

                _context.Add(newEmployee);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = newEmployee.Sid });
            }

            return View();

            //try
            //{

            //    _context.Add(b);
            //    _context.SaveChanges();
            //    ViewBag.message = b.SName + " successfully registered";
            //    return RedirectToAction("Login");

            //}
            //catch (Exception e)
            //{

            //    ViewBag.message = b.SName + " registration failed";
            //    return View();
            //}


        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Seller b)
        {
            var loguser = _context.SellerDb.Where(e => e.SName == b.SName && e.Pass == b.Pass).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.Message = "not valid user";
                return View();
            }
            else
            {
                
                return RedirectToAction("Register","Layout");
            }
        }
        // GET: Seller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
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

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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
            var result = _context.SellerDb.Where(e => e.Email == email).ToList();
            if (result.Count == 0)
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