using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lifts.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string BookingsEndpoint = $"{Prefix}/Bookings";
        public static readonly string CustomersEndpoint = $"{Prefix}/Customers";
        public static readonly string PaymentsEndpoint = $"{Prefix}/Payments";
        public static readonly string StaffsEndpoint = $"{Prefix}/Staffs";
        public static readonly string VehiclesEndpoint = $"{Prefix}/Vehicles";
        public static readonly string VehicleBrandsEndpoint = $"{Prefix}/VehicleBrands";
        public static readonly string VehicleSeatersEndpoint = $"{Prefix}/VehicleSeaters";
        public static readonly string VehicleTypesEndpoint = $"{Prefix}/VehicleTypes";

    }
}
