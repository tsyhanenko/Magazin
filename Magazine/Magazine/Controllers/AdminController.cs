using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class AdminController : Controller
    {
        Model1 context;
     public AdminController()
        {
            context = new Model1();
        }
        // GET: Admin
        public ActionResult Index()
        {
            var model = context.GoodsDbSet;
            return View(model);
        }

        public ActionResult Edit()
        {
            var model = context.GoodsDbSet;
            return View(model);
        }

    }
}
