﻿using Bazzar.Core.Domain.Advertisements.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Infrastructures.Data.SqlServer
{
  public  class AdvertismentDbContext:DbContext
    {

        public AdvertismentDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        }

        public DbSet<Advertisment> Advertisments { get; set; }
       // public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
