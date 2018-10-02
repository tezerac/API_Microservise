using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class TicketAvailability
    {
        public int Id { get; set; }
        public Boolean IsAvailable { get; set; }
        public Decimal MinimumPrice { get; set; }
        public Decimal MaximumPrice { get; set; }
        public Boolean IsSoldOut { get; set; }//atleast one available
        public DateTime SalesStartDate { get; set; }
    }
}
