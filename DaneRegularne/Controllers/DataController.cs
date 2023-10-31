using AngleSharp.Html.Dom;
using DaneRegularne.Models;
using Microsoft.AspNetCore.Mvc;

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
                // return RedirectToAction("Wynik",dane);
                 return RedirectToAction("Wynik", dane);

            }

            return View("Form");


        }
        //ZAQ!2wsx

        public IActionResult Wynik(DataModel dane)
        {
            return View("Wynik", dane);
        }
        //public IActionResult Formtwo(DataModel dane)
        //{
        //    return View("Form",dane);
        //}
    }
}
