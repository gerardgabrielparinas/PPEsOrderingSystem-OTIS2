using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PPEsOrderingSystem.Models;
using Login_Registration_Page.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace PPEsOrderingSystem.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public StoreController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index(int? c)
        {
            var products = _context.Class
                .Include(p => p.category)
                .ToList();

            if (c != null)
            {
                products = products.Where(p => p.Catid == (int)c)
                    .ToList();
            }

            var categories = _context.Categories
                .OrderBy(c => c.Name)
                .ToList();

            var record = new StoreViewModel()
            {
                ProductList = products,
                CategoryList = categories
            };

            return View(record);
        }

        public IActionResult Search()
        {
            var displaydata = _context.Class.ToList();
            return View("Index", displaydata);
        }

        [HttpGet]
        public async Task<IActionResult> Search(String ProductSearch)
        {
            ViewData["GetSupplierDetails"] = ProductSearch;

            var productquery = from x in _context.Class select x;
            if (!String.IsNullOrEmpty(ProductSearch))
            {
                productquery = productquery.Where(x => x.ProductName.Contains(ProductSearch) || x.Description.Contains(ProductSearch));
            }
            return View("Index", await productquery.AsNoTracking().ToListAsync());
        }
    }
}
