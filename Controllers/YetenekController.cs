using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebCv.Models.Entity;
using MyWebCv.Repositories;

namespace MyWebCv.Controllers
{
    public class YetenekController : Controller
    {
        GenericRepositories<Skills_Table> repo = new GenericRepositories<Skills_Table>();
        // GET: Yetenek


        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YetenekEkle(Skills_Table p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            Skills_Table t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
    }
}