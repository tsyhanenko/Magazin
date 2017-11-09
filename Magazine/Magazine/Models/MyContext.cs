using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public interface IMyContext
    {
        IEnumerable<Model1> GetGoods();
    }
    public class MyContext : IMyContext
    {
        public MyContext()
        public IEnumerable<Model1> GetGoods()
        {
            
        }
    }
}