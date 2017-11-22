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
		Model1 context;

		public MyContext(Model1 t)
		{
			context = t;
		}

		public IEnumerable<Model1> GetGoods()
        {
			yield return context;
		}
    }
}