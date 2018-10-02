using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventCatagory
    {
        public int CatagoryID { get; set; }
        public string CatagoryName { get; set; }
        public string NameLocalized { get; set; }
        public string ShortName { get; set; }
        public string Subcatagory { get; set; }
    }
}
