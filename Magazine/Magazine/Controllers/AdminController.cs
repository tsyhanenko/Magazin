using ClassLibrary1.DB;
using Magazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class AdminController : Controller
    {
        static List<goods> Goods = StaffRepository.GetRep();
       // Model1 context;
     public AdminController()
        {
           // context = new Model1();
        }
        // GET: Admin
        public ActionResult Index()
        {
            var model = Goods;
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            goods s = null;
            if(id!=0)
            {
                s = Goods.FirstOrDefault(x => x.GoodId == id);
            }
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(goods a)
        {
            if (ModelState.IsValid)
            {

                int index = Goods
                    .IndexOf(Goods.FirstOrDefault(x => x.GoodId == a.GoodId));
                if (index != -1)
                    Goods[index] = a;
                else
                {
                    Goods.Add(a);
                    a.GoodId = Goods.Max(x => x.GoodId) + 1;
                }
                return RedirectToAction("Index");
            }
            else
                return View(a);
        }
            public ActionResult Remove(int? id = null)
        {
            if(id!= null)
            {
                goods temp = Goods.FirstOrDefault(x => x.GoodId == id);
                Goods.Remove(temp);
            }
            return RedirectToAction("Edit");
        }
       

    }
}
