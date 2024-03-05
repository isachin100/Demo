using Microsoft.EntityFrameworkCore;
using NewsPlatform.Domains.Entities;
using System.Reflection;
using WillsPlatform.Application;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext, IDbContext
    {
        public DbSet<News> News { get; set; }

        public ApplicationDbContext(DbContextOptions options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}