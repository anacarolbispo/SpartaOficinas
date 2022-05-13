using System;
using System.ComponentModel.DataAnnotations;

namespace SpartaOficinas.Models.Validations
{
    public class ValidaData : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dataAgendamento = Convert.ToDateTime(value);

            if (dataAgendamento.DayOfWeek != DayOfWeek.Sunday && dataAgendamento.DayOfWeek != DayOfWeek.Saturday)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}
