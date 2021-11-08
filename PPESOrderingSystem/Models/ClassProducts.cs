using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using System.ComponentModel.DataAnnotations;
namespace PPEsOrderingSystem.Models
{
    public class ClassProducts
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int Price { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }
    }
}
