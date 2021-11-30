using Microsoft.AspNetCore.Mvc;
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
    public class PrintMeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PrintMeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin,Supplier")]
        public IActionResult Print()
        {
            var list = _context.Class.Include(p => p.category).ToList();
            return View(list);
        }
    }
}