
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySite.Models;

namespace MySite.Data
{
    public class AppDbContext: IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Vechile> Vechile { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
        }

    }
}
