using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lifts.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerUsername { get; set; }
        [Required]
        public string CustomerPassword { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int CustomerContactNumber { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]{3}\d{4}[A-Za-z]", ErrorMessage = "License Plate Number does not meet requirements")]
        public string CustomerLicense { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        public virtual List<Booking> Booking { get; set; }
    }
}
