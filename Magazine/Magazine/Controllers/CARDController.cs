using ClassLibrary1.DB;
using Magazine.Models;
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
        // Model1 context;
        static List<goods> Goods = StaffRepository.GetRep();
        public CARDController()
        {
            //context = new Model1();
        }

        public ActionResult Index()
        {
            ViewBag.Goods = Goods;
            return View();
        }

        public ActionResult AddItem()
        {

            return View();
        }
    }
}