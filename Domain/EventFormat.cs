using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventFormat
    {
        public int EventFormatID { get; set; }
        public string EventFormatName { get; set; }
        public string ShortName { get; set; }
    }
}
