using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyWebCv.Models.Entity;

namespace MyWebCv.Controllers
{

    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginValidation_Table admin)
        {
            Db_CvEntities db = new Db_CvEntities();


            var bilgi = db.LoginValidation_Table.FirstOrDefault(x => x.Username == admin.Username && x.PassWord == admin.PassWord);

            if(bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.Username,false);
                Session["Username"] = bilgi.Username.ToString();
                return RedirectToAction("Index", "Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}