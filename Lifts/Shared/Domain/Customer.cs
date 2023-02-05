using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string CustomerName { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public int CustomerContactNumber { get; set; }
        public string CustomerLicense { get; set; }
        public string CustomerEmail { get; set; }
        public virtual List<Booking> Booking { get; set; }
    }
}
