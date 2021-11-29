using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PPEsOrderingSystem.Models;
using Login_Registration_Page.Data;
using System.Net.Mail;
using System.Net;

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
            MailMessage mail = new MailMessage()
            {
                From = new MailAddress("benilde.web.development@gmail.com", "The Administrator")
            };
            mail.To.Add(new MailAddress(record.Email));

            mail.Subject = "Inquiry from " + record.Sender + " (" + record.Subject + ") ";
            string message = "Hello, " + record.Sender + "<br/><br/>" +
                "We have recieved your inquiry. Here are the details: <br/><br/>" +
                "Contact Number: " + record.ContactNo + "<br/>" +
                "Message:<br/>" + record.Message + "<br/><br/>" +
                "Please wait for our reply. Thank you.";

            mail.Body = message;
            mail.IsBodyHtml = true;

            using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("gaboparinas78@gmail.com", "rnbwtsuclfnizxzz"),
                EnableSsl = true
            };
            smtp.Send(mail);
            ViewBag.Message = "Inquiry Sent.";
            return View();
        }


    }
}
