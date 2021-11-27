using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login_Registration_Page.Data;


using System.ComponentModel.DataAnnotations;
namespace PPEsOrderingSystem.Models
{
    public class ClassProducts
    {
        private readonly ApplicationDbContext _context;
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int Price { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }

        public ClassProducts find(int id)
        {
            var products = _context.Class.ToList();
            var prod = products.Where(a => a.ProductID == id).FirstOrDefault();
            return prod;
        }
    }
}
