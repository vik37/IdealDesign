using Asp.NetCore_IdealDesign.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Asp.NetCore_IdealDesign.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.context1 = "Дозволете ни вашиот простор да го претвориме во ваше омилено место.";
            ViewBag.context2 = "За модерен стилски квалитетен мебел";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Ideal Design";

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
