using MiastaMieścinyMiasteczka.Data.Interfaces;
using MiastaMieścinyMiasteczka.Data.Repositories.NewFolder;
using MiastaMieścinyMiasteczka.Entities;
using System.Collections.Generic;

namespace MiastaMieścinyMiasteczka.Data
{
    public class CityRepository : ICityRepository
    {
        private readonly CityContext _context;


        public CityRepository(CityContext context)
        {
            _context = context;
            if (!_context.Cities.Any())
            {
                // Baza danych jest pusta, więc dodaj 5 dowolnych miast
                context.Cities.AddRange(CitySeed.GetSampleCities());
                context.SaveChanges();
            }
        }

        public IEnumerable<City> GetAllCities()
        {
            return _context.Cities.ToList();
        }

        public City GetCityById(int id)
        {
            return _context.Cities.Find(id);
        }

        public City AddCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return city;
        }

        public void UpdateCity(City city)
        {
            _context.Cities.Update(city);
            _context.SaveChanges();
        }

        public void DeleteCity(int id)
        {
            var city = _context.Cities.Find(id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }
        }
    }
}
