using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PPEsOrderingSystem.Models;
using Login_Registration_Page.Data;

namespace PPEsOrderingSystem.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact record)
        {
            var contact = new Contact()
            {
                TicketNumber = record.TicketNumber,
                FirstName = record.FirstName,
                LastName = record.LastName,
                Email = record.Email,
                Message = record.Message
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
