using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    class Trackerappcontext : DbContext

    {
        public DbSet<Tracker> Trackers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tracker>(entity =>
           {
               entity.HasKey(a => a.Username).HasName("PK_Trackers");

               entity.Property(a => a.DayOfWeek).IsRequired();

               entity.Property(a => a.TypeofMeal).IsRequired();

               entity.Property(a => a.CaloriesAmount).IsRequired().HasMaxLength(10);

               entity.ToTable("Trackers");

           });
        }
    }
}
