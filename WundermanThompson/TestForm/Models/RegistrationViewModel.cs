using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestForm.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Organisation { get; set; }
        [Required]
        public string WorkEmail { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string[] Options { get; set; }
        public string Comment { get; set; }
        [Required]
        public string Industry { get; set; }
    }
}
