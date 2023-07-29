using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebCv.Models.Entity;
using MyWebCv.Repositories;

namespace MyWebCv.Controllers
{
    
    public class IletisimController : Controller
    {
        GenericRepositories<Connection_Table> repo = new GenericRepositories<Connection_Table>();
        // GET: Iletisim
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}