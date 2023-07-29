using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebCv.Models.Entity;
using MyWebCv.Repositories;

namespace MyWebCv.Controllers
{
    public class AboutController : Controller
    {

        GenericRepositories<About_Table> repo = new GenericRepositories<About_Table>();
        // GET: About

        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }

        [HttpPost]
        public ActionResult Index(About_Table p)
        {
            var t = repo.Find(x => x.ID == 1);

            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Adress = p.Adress;
            t.Mail = p.Mail;
            t.Aciklama = p.Aciklama;
            t.Photo = p.Photo;

            repo.TUpdate(t);

            return RedirectToAction("Index");
        }
    }
}