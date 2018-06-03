﻿using Microsoft.EntityFrameworkCore;

namespace CrossSolar.Domain
{
    public class CrossSolarDbContext : DbContext
    {
        public virtual DbSet<Panel> Panels { get; set; }

        public virtual DbSet<OneHourElectricity> OneHourElectricitys { get; set; }

        public CrossSolarDbContext()
        {  

        }

        public CrossSolarDbContext(DbContextOptions<CrossSolarDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}