using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public class PageLinks
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public int CountPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / CountPerPage);
            }
        }
    }
}