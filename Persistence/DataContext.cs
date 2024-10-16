using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Activities on taulukon nimi tietokannassa.
        public DbSet<Activity> Activities { get; set; }
    }
}