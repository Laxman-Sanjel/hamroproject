
using Bca_New.Models;
using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
 namespace Bca_New.Data
        {
    public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            }
            public DbSet<Players> Player { get; set; }
            
    }
    }