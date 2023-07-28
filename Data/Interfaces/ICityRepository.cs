using MiastaMieścinyMiasteczka.Entities;

namespace MiastaMieścinyMiasteczka.Data.Interfaces
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAllCities();
        City GetCityById(int id);
        City AddCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int id);
    }
}
