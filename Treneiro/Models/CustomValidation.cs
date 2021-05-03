using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Treneiro.Models
{
    public class CustomValidation
    {
    }

    public class DateOfBirthAttribute : ValidationAttribute
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var val = (DateTime)value;
            try
            {
                string msg = $"Błędna data urodzenia (akceptowany wiek: {MinAge}-{MaxAge} lat).";
                if (val.AddYears(MinAge) > DateTime.Now || val.AddYears(MaxAge) < DateTime.Now)
                    return new ValidationResult(msg);
                else
                    return ValidationResult.Success;
            }
            catch (Exception e)
            {
                return new ValidationResult(e.Message);
            }
        }
    }
}
