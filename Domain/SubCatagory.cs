using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class SubCatagory
    {
        //public int SubCatagoryID { get; set; }
        public string Name { get; set; }
        public int CatagoryID { get; set; }//fk
    }
}
