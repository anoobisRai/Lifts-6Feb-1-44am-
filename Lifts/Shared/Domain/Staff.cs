using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string StaffName { get; set; }

        public string StaffUsername { get; set; }

        public string StaffPassword { get; set; }

        public int StaffContactNumber { get; set; }

        public string StaffEmail { get; set; }

        public virtual List<Booking> Booking { get; set; }

    }
}