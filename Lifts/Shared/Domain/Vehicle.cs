using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string Plate { get; set; }
        public int TypeID { get; set; }
        public virtual VehicleType Type { get; set; }
        public int BrandID { get; set; }
        public virtual VehicleBrand Brand { get; set; }
        public int SeaterID { get; set; }
        public virtual VehicleSeater Seater { get; set; }
        public virtual List<Booking> Booking { get; set; }
    }
}
