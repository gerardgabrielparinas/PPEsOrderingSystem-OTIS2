using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PPEsOrderingSystem.Models;
using Login_Registration_Page.Data;
using Microsoft.EntityFrameworkCore;


namespace PPEsOrderingSystem.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StoreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Class
                .ToList();

            var record = new StoreViewModel()
            {
                ProductList = products
            };

            return View(record);
        }
    }
}
