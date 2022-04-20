using ProvidenceFund.Validate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace ProvidenceFund.ViewModel
{
    public class EmployeeViewModel
    {
        [Display(Name = "No.")]
        public int Id { get; set; }
        [Display(Name = "First name")]
        [Required]
        public string FirstName { get; set; } = default!;
        [Display(Name = "Last name")]
        [Required]
        public string LastName { get; set; } = default!;
        [Display(Name = "Full name")]
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Address { get; set; } = default!;
        [Display(Name = "Date of birth")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        [DateValidate]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        [Display(Name = "Start work date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartWorkDate { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        [Required]
        public int Salary { get; set; }
        [Display(Name = "Pvd fund rate")]
        [RateValidate]
        [Range(0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public float Rate { get; set; } = 0f;
    }
}
