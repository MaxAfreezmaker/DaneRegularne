using System.ComponentModel.DataAnnotations;

namespace DaneRegularne.Models
{
    public class DataModel
    {
        [Required(ErrorMessage = "Uzupełnij pole swoim imieniem.")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole swoim nazwiskiem.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}
