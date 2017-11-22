using ClassLibrary1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public class GoodsViewModel
    {
        public IEnumerable<goods> Goods { get; set; }
        public PageLinks Pages { get; set; }
        public string Category { get; set; }
    }
}