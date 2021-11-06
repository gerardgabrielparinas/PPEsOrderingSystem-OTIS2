using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required.")]
        public decimal Price { get; set; }

        public string Category { get; set; }

        [Display(Name = "Item Type")]
        public Categories CatID { get; set; }

    }

    public enum Categories
    {
        Category_1 = 1,
        Category_2 = 2,
        Category_3 = 3
    }


}

