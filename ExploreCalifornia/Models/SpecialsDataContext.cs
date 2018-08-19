﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ExploreCalifornia.Models
{
    public class Special
    {
        public long Id { get; set; }
        public string Key { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public int Price { get; internal set; }
    }

    public class SpecialsDataContext : DbContext

    {


        public DbSet<Special> Specials { get; set; }

        public SpecialsDataContext(DbContextOptions<SpecialsDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public IEnumerable<Special> GetMonthlySpecials()
        {
            return Specials.ToArray();
            //return new[]
            //{
            //    new Special {
            //        Key = "calm",
            //        Name = "California Calm Package",
            //        Type = "Day Spa Package",
            //        Price = 250,
            //    },
            //    new Special {
            //        Key = "desert",
            //        Name = "From Desert to Sea",
            //        Type = "2 Day Salton Sea",
            //        Price = 350,
            //    },
            //    new Special {
            //        Key = "backpack",
            //        Name = "Backpack Cali",
            //        Type = "Big Sur Retreat",
            //        Price = 620,
            //    },
            //    new Special {
            //        Key = "taste",
            //        Name = "Taste of California",
            //        Type = "Tapas & Groves",
            //        Price = 150,
            //    },
            //};
        }
    }
}
