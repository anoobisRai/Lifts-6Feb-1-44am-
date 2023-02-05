using Lifts.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lifts.Server.Configurations.Entities
{
    public class VehicleBrandSeedConfiguration : IEntityTypeConfiguration<VehicleBrand>
    {
        public void Configure(EntityTypeBuilder<VehicleBrand> builder)
        {
            builder.HasData(
                new VehicleBrand
                {
                    Id = 1,
                    BrandName = "Audi",

                },
                new VehicleBrand
                {
                    Id = 2,
                    BrandName = "BMW",
                },
                new VehicleBrand
                {
                    Id = 3,
                    BrandName = "Volvo"
                }
                );
        }
    }
}
