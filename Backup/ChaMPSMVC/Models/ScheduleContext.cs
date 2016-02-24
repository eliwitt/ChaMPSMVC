using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ChaMPSMVC.Models
{
    public class ScheduleContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schedule>().ToTable("Scheduler.ChampsSchedules");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}