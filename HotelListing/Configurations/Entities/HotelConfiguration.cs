using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort",
                    Address = "Nema",
                    CountryId = 1,
                    Rating = 4.2
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Triumphant",
                    Address = "Sam Fransisco",
                    CountryId = 2,
                    Rating = 3.7

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Turkey Burage",
                    Address = "Tinka",
                    CountryId = 2,
                    Rating = 3.9
                }
              );
        }
    }
}
