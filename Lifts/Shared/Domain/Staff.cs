using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lifts.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        public string StaffName { get; set; }
        [Required]

        public string StaffUsername { get; set; }
        [Required]

        public string StaffPassword { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int StaffContactNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string StaffEmail { get; set; }

        public virtual List<Booking> Booking { get; set; }

    }
} 