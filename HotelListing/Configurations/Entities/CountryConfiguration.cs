using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Germany",
                    ShortName = "GM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Togo",
                    ShortName = "TG"

                },
                new Country
                {
                    Id = 3,
                    Name = "Turkey",
                    ShortName = "TK"
                }
              );
        }
    }
}
