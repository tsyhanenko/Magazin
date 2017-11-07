using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 context = new Model1();

            goods a = new goods()
            {
                GoodId = 1,
                GoodCategory = "Phones",
                GoodCount = 10,
                GoodDescription = " Eto mobila",
                GoodName = "Iphone",
                GoodPrice = 1000,
                GoodPicture = "qwerty"
            };
            try
            { 
                context.GoodsDbSet.Add(a);
                context.SaveChanges();
                Console.WriteLine("Db created succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
