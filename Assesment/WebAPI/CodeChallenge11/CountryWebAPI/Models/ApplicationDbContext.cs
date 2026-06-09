using System.Data.Entity;

namespace CountryAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Country> Countries { get; set; }
    }
}