using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebCv.Models.Entity;

namespace MyWebCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        Db_CvEntities db = new Db_CvEntities();
        public ActionResult Index()
        {
            var degerler = db.About_Table.ToList();
            return View(degerler);
        }

        public PartialViewResult Education()
        {
            var egitim = db.Education_Table.ToList();
            return PartialView(egitim);
        }

        public PartialViewResult Skills()
        {
            var yetenekler = db.Skills_Table.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Awards()
        {
            var sertifikalar = db.Awards2_Table.ToList();
            return PartialView(sertifikalar);
        }

        public PartialViewResult Experience()
        {
            var deneyim = db.Experiences_Table.ToList();
            return PartialView(deneyim);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Contact(Connection_Table contact)
        {
            contact.Date = DateTime.Now.ToShortDateString();
            db.Connection_Table.Add(contact);
            db.SaveChanges();
            return PartialView();
        }

    }
}