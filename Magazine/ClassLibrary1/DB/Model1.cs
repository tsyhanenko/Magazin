namespace ClassLibrary1.DB
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
       
        public Model1()
            : base("name=Staff")
        {
        }

      public  DbSet<goods>GoodsDbSet { get; set; }
    }

   
}