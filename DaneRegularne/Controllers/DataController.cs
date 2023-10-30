using DaneRegularne.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DaneRegularne.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(DataModel dane)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Wynik", dane);
            }
             return View();

        }
        public IActionResult Wynik(DataModel dane)
        {
            return View(dane);
        }
    }
}
