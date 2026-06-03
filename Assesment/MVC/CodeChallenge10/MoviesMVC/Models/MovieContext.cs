using System.Collections.Generic;
using System.Data.Entity;

namespace MoviesMVC.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieConn")
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
