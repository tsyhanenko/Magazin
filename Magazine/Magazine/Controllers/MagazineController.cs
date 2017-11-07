using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class MagazineController : Controller
    {
        // GET: Magazine
        Model1 context;
        public MagazineController()
        {
            context = new Model1();
        }

        public ActionResult Index()
        {
            var model = context.GoodsDbSet;
            return View();
        }
    }
}