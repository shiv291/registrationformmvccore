using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestForm.Models
{
    public partial  class RegistrationForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organisation { get; set; }
        public string WorkEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Options { get; set; }
        public string Comment { get; set; }
        public string Industry { get; set; }

    }
}
