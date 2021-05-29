using System.Data.Entity;

namespace Lab._4
{
    public class TPTContext : DbContext
    {
        public DbSet<Osoba> Osobas { get; set; }
        public TPTContext() : base("ContextTPT")
        {
            
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Klient>().ToTable("Klienci");
            modelBuilder.Entity<Pracownik>().ToTable("Pracownicy");
        }
    }
}