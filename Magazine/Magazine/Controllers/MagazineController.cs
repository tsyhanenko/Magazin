using ClassLibrary1.DB;
using Magazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class MagazineController : Controller
    {

        IMyContext context;
        //Model1 context;

        public MagazineController(IMyContext c)
        {
            context = c;
        }

        public ActionResult Index()
        {
            var model = context;
            return View(model);
        }
    }
}