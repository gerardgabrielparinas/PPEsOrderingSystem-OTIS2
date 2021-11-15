using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PPEsOrderingSystem.Models
{
    public class Contact
    {
        [Key]
        public int TicketNumber { get; set; }
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

    }
}