using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
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
            builder.Entity<Hotel>().HasData(
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
