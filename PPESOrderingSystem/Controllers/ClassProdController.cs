﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Login_Registration_Page.Data;
using PPEsOrderingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace PPEsOrderingSystem.Controllers
{
    
    public class ClassProdController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClassProdController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin,Supplier")]
        public IActionResult Index()
        {
            var list = _context.Class.Include(p => p.category).ToList();
            return View(list);
        }

        [Authorize(Roles = "Admin,Supplier")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Supplier")]
        [HttpPost]
        public IActionResult Create(ClassProducts record, IFormFile ImagePath)
        {
            var selectedCategory = _context.Categories
                .Where(c => c.CatId == record.Catid).SingleOrDefault();

            var item = new ClassProducts()
            {
                ProductName = record.ProductName,
                Description = record.Description,
                Price = record.Price,
                ImagePath = record.ImagePath,
                DateAdded = DateTime.Now,
                category = selectedCategory,
                Catid = record.Catid

            };

            if (ImagePath != null)
            {
                if (ImagePath.Length > 0)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/img/products", ImagePath.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        ImagePath.CopyTo(stream);
                    }
                    item.ImagePath = ImagePath.FileName;
                }
            }
            _context.Class.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin,Supplier")]
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

        [Authorize(Roles = "Admin,Supplier")]
        [HttpPost]
        public IActionResult Edit(int? id, ClassProducts record)
        { 
            var item = _context.Class.Where(i => i.ProductID == id).SingleOrDefault();

            var selectedCategory = _context.Categories
                .Where(c => c.CatId == record.Catid).SingleOrDefault();

            item.ProductName = record.ProductName;
            item.Description = record.Description;
            item.Price = record.Price;
            item.ImagePath = record.ImagePath;
            item.DateModified = DateTime.Now;
            item.category = selectedCategory;
            item.Catid = record.Catid;

            _context.Class.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin,Supplier")]
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


        public IActionResult Details(int? id)
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

        string BindDataTable(int? id)
        {
            var item = _context.Class.Where(i => i.ProductID == id).SingleOrDefault();

            string table = "<table>";
            table += "<tr><td>Name: </td></tr><tr><td>" + item.ProductName + "</td></tr>";
            table += "<tr><td>Description: </td></tr><tr><td>" + item.Description + "</td></tr>";
            table += "</table>";
            return table;
        }

        public IActionResult Cart()
        {
            var list = _context.Class.Include(p => p.category).ToList();
            return View(list);
        }

    }
}