using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentistAppoinmentWebApp.Context;
using DentistAppoinmentWebApp.Models;

namespace DentistAppoinmentWebApp.Controllers
{
    public class RegistrationController : Controller
    {

        DentistContext db = new DentistContext();


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Users user, HttpPostedFileBase file)
        {

            string filename = System.IO.Path.GetFileName(file.FileName);

            /*Saving the file in server folder*/
            file.SaveAs(Server.MapPath("~/Images/" + filename));

            user.Image = "Images/" + filename;




            if (ModelState.IsValid)
            {
                db.Userses.Add(user);
                db.SaveChanges();
                return RedirectToAction("Confirmation");
            }

            return View(user);
        }

        public ActionResult Confirmation()
        {
            return View();
        }
	}
}