using MyWebCv.Models.Entity;
using MyWebCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebCv.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim

        EgitimRepository repo = new EgitimRepository();
        public ActionResult Index()
        {
            var egitimlerim = repo.List();
            return View(egitimlerim);
        }

        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EgitimEkle(Education_Table p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult EgitimSil(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EgitimGetir(int id)
        {
            Education_Table t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult EgitimGetir(Education_Table p)
        {
            Education_Table t = repo.Find(x => x.ID == p.ID);

            t.Header = p.Header;
            t.SecondHeader = p.SecondHeader;
            t.LastHeader = p.LastHeader;
            t.GNO = p.GNO;
            t.Date = p.Date;

            repo.TUpdate(t);

            return RedirectToAction("Index");
        }
    }
}