using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Treneiro.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Podaj imię (3-100 znaków)."), MaxLength(100), MinLength(3)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Podaj nazwisko (3-255 znaków)."), MaxLength(255), MinLength(3)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }

        [Display(Name = "Adres email")]
        [Required(ErrorMessage = "Pole obowiązkowe")]
        [EmailAddress(ErrorMessage = "Błędny adres email")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Telefon")]
        [RegularExpression("(?<!\\w)(\\(?(\\+|00)?\\d{2}\\)?)?[ -]?\\d{3}[ -]?\\d{3}[ -]?\\d{3}(?!\\w)", ErrorMessage = "Błędny format numeru.")]
        public string Phone { get; set; }

        [Display(Name = "Płeć")]
        [Required(ErrorMessage ="Podaj płeć")]
        public short Sex { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [DateOfBirth(MinAge = 18, MaxAge = 100)]
        public DateTime DOB { get; set; }

        [Display(Name = "Profil facebook", Prompt = "https://facebook.com/twoja_nazwa")]
        [Url(ErrorMessage = "Błędny link")]
#nullable enable
        public string? Social_fb { get; set; }
#nullable disable

        [Display(Name = "Profil instagram", Prompt = "https://instagram.com/twoja_nazwa")]
        [Url(ErrorMessage = "Błędny link")]
#nullable enable
        public string? Social_instagram { get; set; }
#nullable disable

        [Display(Name = "Data utworzenia")]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;

        public bool Deleted { get; set; } = false;

        public int TrainerID { get; set; }
        public Trainer Trainer { get; set; }
    }
}
