using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lifts.Shared.Domain;

namespace Lifts.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
        new Customer
        {
            Id = 1,
            CustomerName = "John Lee",
            CustomerUsername = "Rock Johnson",
            CustomerPassword = "91290002U",
            CustomerContactNumber = 91290002,
            CustomerLicense = "123A",
            CustomerEmail = "JohnLee@gmail.com"
        },
        new Customer
        {
            Id = 2,
            CustomerName = "Mary Jane",
            CustomerUsername = "Spidey lover",
            CustomerPassword = "1111111A",
            CustomerContactNumber = 91010100,
            CustomerLicense = "234A",
            CustomerEmail = "MaryJane@gmail.com"
        }
        );
        }
    }
}