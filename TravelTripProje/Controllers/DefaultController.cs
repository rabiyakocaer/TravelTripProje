using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Defaul;
        Context c = new Context();
        public ActionResult Index()
        {
            var değerler = c.Blogs.Take(4).ToList();
            return View(değerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var değerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();

            return PartialView(değerler);
        }
        public PartialViewResult Partial2()
        {
            var değerler = c.Blogs.Where(x => x.ID == 1).ToList();

            return PartialView(değerler);
        }
        public PartialViewResult Partial3()
        {
            var değer = c.Blogs.Take(10).ToList();

            return PartialView(değer);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var değer = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(değer);
        }
    }
}