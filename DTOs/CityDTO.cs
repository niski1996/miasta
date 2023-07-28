using MiastaMieścinyMiasteczka.DTOs.HelperClass;

namespace MiastaMieścinyMiasteczka.DTOs
{
    public class CityDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public string Country { get; set; }
        public Region Region { get; set; }
    }
}
