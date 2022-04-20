using System;
using System.ComponentModel.DataAnnotations;
namespace ProvidenceFund.Models
{
    public class PvdFund
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartWorkDate { get; set; }
        public int Salary { get; set; }
        public float Rate { get; set; }
    }
}
