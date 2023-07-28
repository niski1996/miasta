using MiastaMieścinyMiasteczka.DTOs.HelperClass;
using System.ComponentModel.DataAnnotations;

namespace MiastaMieścinyMiasteczka.DTOs
{
    public class CityCreationDTO
    {

        [Required(ErrorMessage = "Kraj jest wymagany.")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Kraj musi mieć od 2 do 40 znaków.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Miasto jest Wymagane.")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Miasto musi mieć od 2 do 40 znaków.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Liczba ludności jest wymagana.")]
        [Range(1, int.MaxValue, ErrorMessage = "Liczba ludności musi być większa niż 0.")]
        public int Population { get; set; }
    }
}
