using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PPEsOrderingSystem.Models
{
    public class SupplierInfo
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Format")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public virtual Category category { get; set; }

        public int? Catid { get; set; }
    }
}
