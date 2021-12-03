using Login_Registration_Page.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPEsOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPEsOrderingSystem.Controllers
{
    public class SupplierInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SupplierInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin,Supplier")]
        public IActionResult Index()
        {
            var list = _context.SupplierInfo.Include(p => p.category).ToList();
            return View(list);
        }

        [Authorize(Roles = "Admin,Supplier")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Supplier")]
        [HttpPost]
        public IActionResult Create(SupplierInfo record)
        {
            var selectedCategory = _context.Categories
                .Where(c => c.CatId == record.Catid).SingleOrDefault();

            var item = new SupplierInfo()
            {
                ContactNumber = record.ContactNumber,
                Email = record.Email,
                Address = record.Address,
                category = selectedCategory,
                Catid = record.Catid,
                SocialMedia = record.SocialMedia
            };

            _context.SupplierInfo.Add(item);
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

            var item = _context.SupplierInfo.Where(i => i.ID == id).SingleOrDefault();

            if (item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [Authorize(Roles = "Admin,Supplier")]
        [HttpPost]
        public IActionResult Edit(int? id, SupplierInfo record)
        {
            var item = _context.SupplierInfo.Where(i => i.ID == id).SingleOrDefault();

            var selectedCategory = _context.Categories
                .Where(c => c.CatId == record.Catid).SingleOrDefault();

            item.ContactNumber = record.ContactNumber;
            item.Email = record.Email;
            item.Address = record.Address;
            item.category = selectedCategory;
            item.Catid = record.Catid;
            item.SocialMedia = record.SocialMedia;

            _context.SupplierInfo.Update(item);
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

            var item = _context.SupplierInfo.Where(i => i.ID == id).SingleOrDefault();

            if (item == null)
            {
                return RedirectToAction("Index");
            }

            _context.SupplierInfo.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.SupplierInfo.Where(i => i.Catid == id).SingleOrDefault();

            if (item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }
    }
}
