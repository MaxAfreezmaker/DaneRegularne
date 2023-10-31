using System.ComponentModel.DataAnnotations;

namespace DaneRegularne.Models
{
    public class DataModel
    {
        [Required(ErrorMessage = "Uzupełnij pole swoim imieniem.")]
        [MinLength(2, ErrorMessage = "Imię musi składać się z co najmniej 2 znaków.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Uzupełnij pole swoim nazwiskiem.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi składać się z co najmniej 2 znaków.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Podany adres e-mail jest nieprawidłowy.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać hasło.")]
        [MinLength(8, ErrorMessage = "Hasło musi składać się z co najmniej 8 znaków.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i jedną cyfrę.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło.")]
        [Compare("Haslo", ErrorMessage = "Potwierdzenie hasła nie pasuje do hasła.")]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Numer telefonu musi składać się z 9 cyfr.")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Proszę podać wiek w celu ustalenia wiarygodności danych")]
        [Range(11, 80, ErrorMessage = "Wiek musi wynosić od 11 do 80 lat.")]
        public int Wiek { get; set; }

        
        [Required(ErrorMessage = "Proszę wybrać miasto.")]
        public string Miasto { get; set; }
    }
}
