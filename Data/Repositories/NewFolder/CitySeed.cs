using MiastaMieścinyMiasteczka.Entities;

namespace MiastaMieścinyMiasteczka.Data.Repositories.NewFolder
{
     static class CitySeed
    {
        public static IEnumerable<City> GetSampleCities()
        {
            return new List<City>
        {
            new City { Id = 1, Name = "City1", Population = 100000, Country = "Country1" },
            new City { Id = 2, Name = "City2", Population = 200000, Country = "Country2" },
            new City { Id = 3, Name = "City3", Population = 150000, Country = "Country3" },
            new City { Id = 4, Name = "City4", Population = 180000, Country = "Country4" },
            new City { Id = 5, Name = "City5", Population = 250000, Country = "Country5" }
        };
        }
    }
}
