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
        int pagesize = 2;
       // IMyContext context;
        //Model1 context;

        static List<goods> Goods = StaffRepository.GetRep();
        public MagazineController()
		{
	//		context = new Model1();
		}


		public ActionResult Index(int id = 1)
        {
            GoodsViewModel model = new GoodsViewModel
            {
                Goods = Goods.Skip((id - 1) * pagesize).Take(pagesize),
                Pages = new PageLinks
                {
                    CurrentPage = id,
                    TotalItems = Goods.Count(),
                    CountPerPage=pagesize
                
                }
            };

            return View(model);
        }

        public PartialViewResult GetGoodsList(int id =1)
        {
            GoodsViewModel model1 = new GoodsViewModel
            {
                Goods = Goods.Skip((id - 1) * pagesize).Take(pagesize),
                Pages = new PageLinks
                {
                    CurrentPage = id,
                    TotalItems = Goods.Count(),
                    CountPerPage = pagesize

                }
            };
            return PartialView(model1);
        }
    }
}