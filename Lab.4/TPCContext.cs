using System.Data.Entity;

namespace Lab._4
{
    public class TPCContext : DbContext
    { 
        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pc>().Map(x =>
            {
                x.MapInheritedProperties().ToTable("Pecety");
            });
            
            modelBuilder.Entity<Laptop>().Map(x =>
            {
                x.MapInheritedProperties().ToTable("Laptopy");
            });
        }
        
        public TPCContext() : base("ContextTPC")
        {
            
        }
    }
}