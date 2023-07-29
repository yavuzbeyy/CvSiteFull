using MyWebCv.Models.Entity;
using MyWebCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebCv.Controllers
{
    public class DeneyimController : Controller
    {


        // GET: Deneyim 
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeneyimEkle(Experiences_Table p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeneyimSil(int id)
        {
            Experiences_Table t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            Experiences_Table t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult DeneyimGetir(Experiences_Table p)
        {
            Experiences_Table t = repo.Find(x => x.ID == p.ID);
            t.Header = p.Header;
            t.SecondHeader = p.SecondHeader;
            t.Explanation = p.Explanation;
            t.Date = p.Date;
            
            repo.TUpdate(t);

            return RedirectToAction("Index");
        }
    }
}