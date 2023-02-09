using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lifts.Shared.Domain;

namespace Lifts.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
        new Staff
        {
            Id = 1,
            StaffName = "Provin Lee",
            StaffUsername = "Rock Johnson",
            StaffPassword = "91290002U",
            StaffContactNumber = 91290002,
            StaffEmail = "ProvinLee@gmail.com"
        },
        new Staff
        {
            Id = 2,
            StaffName = "Gwen Stacy",
            StaffUsername = "Spiderman2",
            StaffPassword = "1111111A",
            StaffContactNumber = 91010100,
            StaffEmail = "GwenStacy@gmail.com"
        },
        new Staff
        {
            Id = 3,
            StaffName = "Ong Yan Lee",
            StaffUsername = "Zalrenic Johnson",
            StaffPassword = "2101115J",
            StaffContactNumber = 82683263,
            StaffEmail = "Ongyanyanz@gmail.com"
        },
        new Staff
        {
            Id = 4,
            StaffName = "Anoobie",
            StaffUsername = "oowie jonny",
            StaffPassword = "2101646D",
            StaffContactNumber = 81129750,
            StaffEmail = "anoobiez@gmail.com"
        }
        );
        }
    }
}