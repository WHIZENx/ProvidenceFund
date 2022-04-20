using System;
using System.ComponentModel.DataAnnotations;

#nullable enable

namespace ProvidenceFund.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string FullName { get { return FirstName + " " + LastName; } }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } = default!;
    }
}
