using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public class StaffRepository
    {
        static List<goods> Goods = new List<goods>
        {
            new goods()
            {
                GoodId = 1,
                GoodCategory = "Phones",
                GoodDescription = " Eto mobila",
                GoodName = "Iphone",
                GoodPrice = 1000,
                GoodPicture = "1.jpg"
            },
             new goods()
            {
                GoodId = 2,
                GoodCategory = "Phones",
                GoodDescription = " Eto mobila",
                GoodName = "Iphone",
                GoodPrice = 1000,
                GoodPicture = "1.jpg"
            },
              new goods()
            {
                GoodId = 3,
                GoodCategory = "Phones",
                GoodDescription = " Eto mobila",
                GoodName = "Iphone",
                GoodPrice = 1000,
                GoodPicture = "1.jpg"
            }, new goods()
            {
                GoodId = 4,
                GoodCategory = "Phones",
                GoodDescription = " Eto mobila",
                GoodName = "Iphone",
                GoodPrice = 1000,
                GoodPicture = "1.jpg"
            }, new goods()
            {
                GoodId = 5,
                GoodCategory = "Phones",
                GoodDescription = " Eto mobila",
                GoodName = "Iphone",
                GoodPrice = 1000,
                GoodPicture = "1.jpg"
            }
    };
        public static List<goods> GetRep()
        {
            return Goods;
        }
    }
}