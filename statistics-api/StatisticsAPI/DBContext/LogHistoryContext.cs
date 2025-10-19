using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using StatisticsAPI.Entity;

namespace StatisticsAPI.DBContext
{
    public class LogHistoryContext : DbContext
    {
        public LogHistoryContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<LogHistory> LogHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LogHistory>().ToCollection("log_history_collection").Property(t => t.Id).ValueGeneratedOnAdd();
        }
    }
}