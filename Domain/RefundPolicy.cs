using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class RefundPolicy
    {
        public int RefundPolicyID { get; set; }
        public string RefundPolicyType { get; set; }
        public int TotlaValidityDays { get; set; }

    }
}
