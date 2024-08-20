using Microsoft.EntityFrameworkCore;
using OLIVIA_S_BAKERY___BACKEND.model;

namespace OLIVIA_S_BAKERY___BACKEND
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("usuario");
            builder.Entity<User>().HasKey(x => x.Id);
            builder.Entity<User>().Property(u => u.Id).HasColumnName("idUser");

            builder.Entity<Product>().ToTable("producto");
            builder.Entity<Product>().HasKey(x => x.Id);
            base.OnModelCreating(builder);
        }
    }
}