using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DB
{
   public class goods
    {
       
       [Key]
        public int GoodId { get; set; }

        public string GoodName { get; set; }
        public string GoodCategory { get; set; }

        public int GoodCount { get; set; }
        public string GoodDescription { get; set; }
        public string GoodPicture { get; set; }
        public int GoodPrice { get; set; }
    }
}
