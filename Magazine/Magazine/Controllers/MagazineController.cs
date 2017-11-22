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

       // IMyContext context;
        //Model1 context;
        static List<goods> Goods = StaffRepository.GetRep();
        public MagazineController()
		{
	//		context = new Model1();
		}

		public ActionResult Index()
        {
            var model = Goods;
            return View(model);
        }
    }
}