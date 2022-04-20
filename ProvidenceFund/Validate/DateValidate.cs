using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvidenceFund.Validate
{
    public class DateValidate : ValidationAttribute
    {
        private readonly DateTime _maxValue = DateTime.UtcNow;

        protected override ValidationResult
            IsValid(object value, ValidationContext validationContext)
        {
            DateTime val = ((DateTime)value).AddYears(543); // Convert Datetime input to UTC Now.
            if (val < _maxValue) return ValidationResult.Success;
            else return new ValidationResult("The field Date of birth must be less than present date time.");
        }
    }
}
