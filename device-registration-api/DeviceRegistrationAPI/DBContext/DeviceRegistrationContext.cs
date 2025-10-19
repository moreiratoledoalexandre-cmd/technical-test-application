using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceRegistrationAPI.Entity;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace DeviceRegistrationAPI.DBContext
{
    public class DeviceRegistrationContext : DbContext
    {
        public DeviceRegistrationContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<UserDevices> UserDevices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDevices>().ToCollection("user_devices_collection");
        }
    }
}