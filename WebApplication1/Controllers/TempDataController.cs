using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult First()
        {
            TempData["Title"] = "First";
            TempData["Title2"] = "First";
            ViewBag.Page = "First";

            TempDataDto tempData = new TempDataDto();
            


            return View("Ortak", tempData);
        }

        public IActionResult Second()
        {
            string val = TempData.Peek("title")?.ToString();   //  ? tempdata boş değilse stringe çevir. peek sadece bu datayı tutar.
            string val2 = TempData["Title2"]?.ToString();
            ViewBag.Page = "Second";
            //TempData.Keep(); // buradaki tüm dataları tutar. 

            TempDataDto tempData = new TempDataDto()
            {
                Title = val,
                Title2 = val2

            };
            return View("Ortak", tempData);
        }

        public IActionResult Third()
        {
            string val = TempData["Title"]?.ToString();
            string val2 = TempData["Title2"]?.ToString();
            ViewBag.Page = "Third";

            TempDataDto tempData = new TempDataDto()
            {
                Title = val,
                Title2 = val2

            };
            return View("Ortak", tempData);
        }
    }

    public class TempDataDto
    {
        public string Title { get; set; }
        public string Title2 { get; set; }
    }
}