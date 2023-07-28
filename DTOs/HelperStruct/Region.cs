using MiastaMieścinyMiasteczka.Entities;

namespace MiastaMieścinyMiasteczka.DTOs.HelperClass
{

    public struct Region
    {
        public Region(string country, City city)
        {
            Country = country;
            City = city;
        }

        public string Country { get; set; }
        public City City { get; set; }

    }
}

