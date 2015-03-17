using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Security;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Web.SessionState;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Powerlink;

namespace Powerlink.Controllers
{
    public class AdminController : Controller
    {
        private PowerlinkEntities db = new PowerlinkEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.AdminModel user, string returnUrl)
        {
                 var password_encrypt = (user.Admin_Password != null) ? Helpers.SHA1.Encode(user.Admin_Password) : null;
                var myUser = db.Admins.FirstOrDefault(u => u.Admin_Username == user.Admin_Username
                                                        && u.Admin_Password == password_encrypt);
                if (myUser != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Admin_Username, user.RememberMe);
                    Session['username']
                    return RedirectToAction("Index", "Equipments");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            
            return RedirectToAction("Index", "Home");

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Admin_Username,Admin_Password,Admin_FName,Admin_LName")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                admin.Admin_Password = Helpers.SHA1.Encode(admin.Admin_Password);
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admin);
        }
    }

}
