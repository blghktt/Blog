using Blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Blog3.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (model.UserName == "admin" && model.Passwd == "admin")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return Redirect("/Blog/Index");
            }
            else
            {
                ModelState.AddModelError("", "Hibás felhasználónév vagy jelszó");
                return View(model);
            }

        }
    }
}