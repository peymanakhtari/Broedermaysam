using Maysam.Models;
using Microsoft.EntityFrameworkCore;

namespace Maysam.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
     //  optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MaysamDB;Integrated Security=True");
            optionsBuilder.UseSqlServer("Data Source = 5.9.192.37,2019; Persist Security Info=True; User ID = broederm_; Password = *Tw7@H567ZcStt");
      //  optionsBuilder.UseSqlServer("Data Source = .; Persist Security Info=True; User ID = broederm_; Password = *Tw7@H567ZcStt");
        }
    }
}
