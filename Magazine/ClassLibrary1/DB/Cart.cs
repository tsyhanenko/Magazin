using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DB
{
    class Cart
    {
        public int CartId { get; set; }
        
        public string GoodId { get; set; }
        public string GoodCategory { get; set; }
    }
}
