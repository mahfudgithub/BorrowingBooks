using BorrowBooks.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowBooks.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Books> TB_M_BOOK { get; set; }
        public DbSet<Members> TB_M_MEMBER { get; set; }
        public DbSet<Transaction> TB_R_BORROW_BOOK { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetDefaultConnectionString(), builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(3), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
        public static string GetDefaultConnectionString()
        {
            return Startup.ConnectionString;
        }
    }
}
