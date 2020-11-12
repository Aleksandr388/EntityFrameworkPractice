using FuneralHome.Data.Entities;
using System.Data.Entity;

namespace FuneralHome.Data
{
    public class FuneralHomeContext : DbContext
    {
        public FuneralHomeContext() : base("Default")
        {
            
        }

        public DbSet<Funeral> Funerals { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Funeral>()
                .HasRequired(x => x.Client)
                .WithMany(x => x.Funerals)
                .HasForeignKey(x => x.ClientId);

            modelBuilder.Entity<Funeral>()
                .HasMany(x => x.Employees)
                .WithMany(x => x.Funerals);
                
        }
    }
}
