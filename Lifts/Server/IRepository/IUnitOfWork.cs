using Lifts.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lifts.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<VehicleBrand> Brands { get; }
        IGenericRepository<VehicleSeater> Seaters { get; }
        IGenericRepository<VehicleType> Types { get; }

    }
}
