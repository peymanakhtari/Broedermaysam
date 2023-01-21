using Maysam.Models;
using Microsoft.EntityFrameworkCore;

namespace Maysam.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MaysamDB;Integrated Security=True");
        }
    }
}
