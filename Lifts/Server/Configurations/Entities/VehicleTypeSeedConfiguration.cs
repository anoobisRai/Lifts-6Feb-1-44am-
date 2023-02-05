using Lifts.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lifts.Server.Configurations.Entities
{
    public class VehicleTypeSeedConfiguration : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.HasData(
                new VehicleType
                {
                    Id = 1,
                    TypeName = "Car",

                },
                new VehicleType
                {
                    Id = 2,
                    TypeName = "Van",
                },
                new VehicleType
                {
                    Id = 3,
                    TypeName = "Coach",
                }
                );
        }
    }
}
