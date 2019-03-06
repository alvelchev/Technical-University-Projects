using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;
using Lab5.Models;

namespace Lab5.Controllers
{

    public class HomeController : Controller
    {
        private readonly ProductContext _context;
        public HomeController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            model.Subject = "";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var selectedItem = contact.Subjects.Find(c => c.Value == contact.Subject);
                if (selectedItem != null)
                {
                    contact.Subject = selectedItem.Text;
                    _context.Add(contact);
                    await _context.SaveChangesAsync();
                    TempData["message"] = "Съобщението от " + contact.FirstName + " " + contact.FamilyName + " от тип " + contact.Subject + " е изпратено успешно към сървъра!";
                    return RedirectToAction("OK", "Home");
                }
            }
            return View(contact);
        }

        public IActionResult OK()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
