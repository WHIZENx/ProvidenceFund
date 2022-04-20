using ProvidenceFund.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvidenceFund.ViewModel
{
    public class ResultViewModel
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; } = default!;
        [Display(Name = "Start work date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartWorkDate { get; set; }
        public int Salary { get; set; }
        [Display(Name = "Pvd fund rate")]
        public float Rate { get; set; }
        [Display(Name = "Total pvd fund")]
        public float TotalPvdFund { get; set; }
    }
}
