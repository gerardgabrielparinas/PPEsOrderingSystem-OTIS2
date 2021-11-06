using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Login_Registration_Page.Data;
using PPEsOrderingSystem.Models;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace PPEsOrderingSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.products.Include(p => p.CatID).ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product record, IFormFile ImagePath)
        {
            var product = new Product()
            {
                Name = record.Name,
                Description = record.Description,
                Price = record.Price,
                CatID = record.CatID
            };

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var product = _context.products.Where(p => p.ProductId == id).SingleOrDefault();
            if (product == null)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Product record)
        {
            var product = _context.products.Where(p => p.ProductId == id).SingleOrDefault();

            product.Name = record.Name;
            product.Description = record.Description;
            product.Price = record.Price;
            product.CatID = record.CatID;

            return View(product);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var product = _context.products.Where(p => p.ProductId == id).SingleOrDefault();
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
