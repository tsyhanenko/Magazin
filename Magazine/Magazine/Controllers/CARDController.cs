using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class CARDController : Controller
    {
        // GET: CARD
        Model1 context;
        public CARDController()
        {
            context = new Model1();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddItem()
        {

            return View();
        }
    }
}