using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Write()
        {
            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddHours(2)
            };

            Response.Cookies.Append("bilgeadam", "yes");

            return View();
        }

        public IActionResult Read()
        {
            string bilgeAdam = Request.Cookies["bilgeadam"];
            return View("Read", bilgeAdam);
        }

        public IActionResult Remove()
        {
            Response.Cookies.Delete("bilgeadam");

            return View("Read");

        }
    }
}
