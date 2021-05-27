using System.Data.Entity;

namespace Lab._4
{
    public class KontektsEF6 : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }
    }
}