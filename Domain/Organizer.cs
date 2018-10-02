using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class Organizer
    {
        public int OrganizerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrganizersURL { get; set; }

    }
}
