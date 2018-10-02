using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class Event
    {
        private Boolean ListedOnSight { get; set; }
        private Boolean Searchable { get; set; }
        private Boolean ForInviteOnly { get; set; }
        private Boolean ShowRemainingTickets { get; set; }
        private String EventPassword { get; set; }
        private int Capacity { get; set; }

        public int EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EventURL { get; set; }
        public DateTime EventstartTime { get; set; }
        public DateTime EventEndTime  { get; set; }
        public DateTime EventCreated { get; set; }
        public DateTime EventChanged { get; set; }
        public string CurrentStatus { get; set; }
        public String Currency { get; set; }
        public Boolean OnlineStatus { get; set; }
        public int BookmarkInfo { get; set; }

        public int LogoID { get; set; }//or logo id FK//optional
        public int VenueID { get; set; }//fk optional
        public int OrganizerID { get; set; }//fk
        public int EventFormatID { get; set; }//conference.seminar workshop..//fk
        public int EventCatagoryID { get; set; }//fk
        public int EventSubCatagory { get; set; }//fk      
        public int RefundPolicy { get; set; }//fk optional
        public int TicketAvailability { get; set; }//fk//optional

        public virtual LogoImage LogoImage { get; set;}
        public virtual Venue Venue { get; set; }
        public virtual Organizer Organizer { get; set; }
        public virtual EventFormat EventFormat { get; set;}
        public virtual EventCatagory EventCatagory { get; set; }
        public virtual SubCatagory SubCatagory { get; set; }
        public virtual RefundPolicy RefundPolicys { get; set; }
        public virtual TicketAvailability TicketAvailabilitys { get; set; }
    }
}
