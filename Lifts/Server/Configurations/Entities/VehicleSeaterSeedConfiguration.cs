using Lifts.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lifts.Server.Configurations.Entities
{
    public class VehicleSeaterSeedConfiguration : IEntityTypeConfiguration<VehicleSeater>
    {
        public void Configure(EntityTypeBuilder<VehicleSeater> builder)
        {
            builder.HasData(
                new VehicleSeater
                {
                    Id = 1,
                    SeaterNumber = 4,

                },
                new VehicleSeater
                {
                    Id = 2,
                    SeaterNumber = 6,
                },
                new VehicleSeater
                {
                    Id = 3,
                    SeaterNumber = 9
                }
                );
        }
    }
}
