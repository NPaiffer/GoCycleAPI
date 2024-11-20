using Microsoft.EntityFrameworkCore;
using ProjectName.Models;

namespace ProjectName.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Usage> Usages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasOne(p => p.User)
                .WithMany(u => u.Profiles)
                .HasForeignKey(p => p.UserId);

        }
    }
}
