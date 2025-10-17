using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using movie_catalog_api.Model;

namespace movie_catalog_api.DBContext
{
    public class MovieCatalogContext : DbContext
    {
        public MovieCatalogContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().ToCollection("movies_collection");
        }
   }
}