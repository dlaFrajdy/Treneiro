using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Treneiro.Models
{
    public class Muscle
    {
        public int MuscleID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Pole obowiązkowe (3-255 znaków)."), MaxLength(255), MinLength(3)]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nazwa łacińska")]
        public string LatinName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Pole obowiązkowe (co najmniej 10 znaków)."), MinLength(10)]
        public string Description { get; set; }

        public bool Deleted { get; set; } = false;
    }
}
