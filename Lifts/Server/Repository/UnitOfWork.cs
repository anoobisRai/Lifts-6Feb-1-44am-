using Lifts.Server.Data;
using Lifts.Server.IRepository;
using Lifts.Server.Models;
using Lifts.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lifts.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Payment> _payments;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<VehicleBrand> _brands;
        private IGenericRepository<VehicleSeater> _seaters;
        private IGenericRepository<VehicleType> _types;


        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }   

        public IGenericRepository<Booking> Bookings
            => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Payment> Payments
            => _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Vehicle> Vehicles
            => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<VehicleBrand> Brands
            => _brands ??= new GenericRepository<VehicleBrand>(_context);
        public IGenericRepository<VehicleSeater> Seaters
    => _seaters ??= new GenericRepository<VehicleSeater>(_context);
        public IGenericRepository<VehicleType> Types
    => _types ??= new GenericRepository<VehicleType>(_context);

        public IGenericRepository<Booking> Booking => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);


            await _context.SaveChangesAsync();
        }
    }
}
