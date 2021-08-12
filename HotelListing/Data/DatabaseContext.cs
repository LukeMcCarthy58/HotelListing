using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Spain",
                    ShortName = "ES"
                },
                new Country
                {
                    Id = 2,
                    Name = "England",
                    ShortName = "EN"
                },
                new Country
                {
                    Id = 3,
                    Name = "France",
                    ShortName = "FR"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Madrid Ibis",
                    Address = "Madrid",
                    CountryId = 1,
                    Rating = 2
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Rockliffe Hall and Spa",
                    Address = "Middlesbrough",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Disneyland Hotel",
                    Address = "Paris",
                    CountryId = 3,
                    Rating = 5
                }
            );
        }
    }
}
