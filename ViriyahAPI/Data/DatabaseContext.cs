using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViriyahAPI.Configurations.Entities;

namespace ViriyahAPI.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);

            //builder.ApplyConfiguration(new CountryConfiguration());
            //builder.ApplyConfiguration(new HotelConfiguration());
            
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());

            //builder.Entity<Country>().HasData(
            //    new Country
            //    {
            //        Id = 1,
            //        Name = "taunthong",
            //        ShortName = "TK"
            //    },
            //                    new Country
            //                    {
            //                        Id = 2,
            //                        Name = "taunthong2",
            //                        ShortName = "TK2"
            //                    },
            //                                    new Country
            //                                    {
            //                                        Id = 3,
            //                                        Name = "taunthong3",
            //                                        ShortName = "TK3"
            //                                    }
            //    );


            //builder.Entity<Hotel>().HasData(
            //    new Hotel
            //    {
            //        Id = 1,
            //        Name = "taunthong",
            //        Address = "TK",
            //        CountryId = 1,
            //        Rating = 1.2,
            //    },
            //                    new Hotel
            //                    {
            //                        Id = 2,
            //                        Name = "taunthong2",
            //                        Address = "TK2",
            //                        CountryId = 2,
            //                        Rating = 2.2,
            //                    },
            //                                    new Hotel
            //                                    {
            //                                        Id = 3,
            //                                        Name = "taunthong3",
            //                                        Address = "TK3",
            //                                        CountryId = 3,
            //                                        Rating = 3.2,
            //                                    }
            //    );

        }
    }
}
