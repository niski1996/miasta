using MiastaMieścinyMiasteczka.Entities;
using Microsoft.EntityFrameworkCore;

namespace MiastaMieścinyMiasteczka.Data
{
    public class CityContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
        }
    }
}
