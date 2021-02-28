using Asp.NetCore_IdealDesign.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
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
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            //ViewBag.context1 = "Дозволете ни вашиот простор да го претвориме во ваше омилено место.";
            ViewBag.context1 = _localizer["Let us turn your space into your favorite place."];
            //ViewBag.context2 = "За модерен стилски квалитетен мебел";
            ViewBag.context2 = _localizer["For modern stylish quality furniture"];
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = _localizer["Contact Ideal Design"];

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

        [HttpPost]
        public IActionResult SetLanguage(string culture,string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1)}
            );
            return LocalRedirect(returnUrl);
        }
    }
}
