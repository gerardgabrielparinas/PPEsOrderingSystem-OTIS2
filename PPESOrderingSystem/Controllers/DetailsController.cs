using Login_Registration_Page.Data;
using Microsoft.AspNetCore.Mvc;
using PPEsOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPEsOrderingSystem.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Details detail)
        {
            var item = new Details()
            {
                ID = detail.ID,
                Title = detail.Title,
                Body = detail.Body
            };

            _context.Details.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
