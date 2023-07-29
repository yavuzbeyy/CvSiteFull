using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebCv.Models.Entity;
using MyWebCv.Repositories;

namespace MyWebCv.Controllers
{
    public class SertifikaController : Controller
    {
        GenericRepositories<Awards2_Table> repo = new GenericRepositories<Awards2_Table>();
        // GET: Sertifika
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult SertifikaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SertifikaEkle(Awards2_Table p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            Awards2_Table t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            Awards2_Table t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult SertifikaGetir(Awards2_Table p)
        {
            Awards2_Table t = repo.Find(x => x.ID == p.ID);
           
            t.Awards = p.Awards;        

            repo.TUpdate(t);

            return RedirectToAction("Index");
        }
    }
}