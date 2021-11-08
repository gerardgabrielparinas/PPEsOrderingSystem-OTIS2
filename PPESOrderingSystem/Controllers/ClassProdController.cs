using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Login_Registration_Page.Data;
using PPEsOrderingSystem.Models;

namespace PPEsOrderingSystem.Controllers
{
    public class ClassProdController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClassProdController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var list = _context.Class.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClassProducts record)
        {
            var item = new ClassProducts()
            {
                ProductName = record.ProductName,
                Description = record.Description,
                Price = record.Price,
                DateAdded = DateTime.Now

            };
            _context.Class.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Class.Where(i => i.ProductID == id).SingleOrDefault();

            if (item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int? id, ClassProducts record)
        {
            var item = _context.Class.Where(i => i.ProductID == id).SingleOrDefault();

            item.ProductName = record.ProductName;
            item.Description = record.Description;
            item.Price = record.Price;
            item.DateModified = DateTime.Now;

            _context.Class.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Class.Where(i => i.ProductID == id).SingleOrDefault();

            if (item == null)
            {
                return RedirectToAction("Index");
            }

            _context.Class.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}