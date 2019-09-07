using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Write([FromQuery] string username, [FromQuery] int userId)
        {
            HttpContext.Session.SetString("username", username);
            HttpContext.Session.SetInt32("userId", userId);
            return View();
        }

        public IActionResult Read([FromQuery] int? userId)
        {
            string username = HttpContext.Session.GetString("username");
            userId = HttpContext.Session.GetInt32("userId");

            Tuple<string, int?> tuple = new Tuple<string, int?>(username, userId);
            return View("Read", tuple);
        }
    }
}