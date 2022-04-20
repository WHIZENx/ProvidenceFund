using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvidenceFund.Validate
{
    public class RateValidate : ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            var model = (ViewModel.EmployeeViewModel)validationContext.ObjectInstance;
            TimeSpan timeSpan = DateTime.UtcNow - model.StartWorkDate;
            int DiffYear = new DateTime(timeSpan.Ticks).Year - 1 - 543; // Convert Datetime input to UTC Now.
            int DiffMonth = new DateTime(timeSpan.Ticks).Month - 1;
            float rate = (float)value;
            if (DiffYear < 0)
            {
                if (rate == 0f) return ValidationResult.Success;
                else return new ValidationResult("Employee that work less than 3 months will not receive the providence fund. (Choose pvd rate equal 0)");
            }
            else if (DiffYear < 1)
            {
                if (DiffMonth <= 3)
                {
                    if (rate == 0f) return ValidationResult.Success;
                    else return new ValidationResult("Employee that work less than 3 months will not receive the providence fund. (Choose pvd rate equal 0)");
                }
                else
                {
                    if (rate > 3) return new ValidationResult("Employee that work less than 1-year company can choose pvd rate not over 3");
                    else return ValidationResult.Success;
                }
            }
            else if (DiffYear < 3)
            {
                if (rate > 5) return new ValidationResult("Employee that work less than 3-year company can choose pvd rate not over 5");
                else return ValidationResult.Success;
            }
            else if (DiffYear < 5)
            {
                if (rate > 8) return new ValidationResult("Employee that work less than 3-year company can choose pvd rate not over 8");
                else return ValidationResult.Success;
            }
            else
            {
                if (rate > 12) return new ValidationResult("Employee that work less than 3-year company can choose pvd rate not over 12");
                else return ValidationResult.Success;
            }
        }
    }
}
