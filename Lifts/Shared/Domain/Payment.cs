using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public int PaymentAmount { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime PaymentTime { get; set; }

        public string PaymentTransaction { get; set; }

        public int BookingID { get; set; }
        public virtual Booking Booking { get; set; }

    }
}