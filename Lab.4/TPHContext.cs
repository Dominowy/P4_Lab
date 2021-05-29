using System.Data.Entity;

namespace Lab._4
{
    public class TPHContext : DbContext
    {
        public DbSet<Osoba> Osobas { get; set; }

        public TPHContext() : base("Context")
        {
            
        }
    }
}