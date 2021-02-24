using IdealDesign_Services.Helper;
using IdealDesign_Services.Interfaces;
using IdealDesign_WebModels.EnumsVM;
using IdealDesign_WebModels.VewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore_IdealDesign.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IHostingEnvironment _env;
        private readonly IToastNotification _toastNotification;
        public UserController(IUserService userService, IHostingEnvironment env, IToastNotification toastNotification)
        {
            _userService = userService;
            _env = env;
            _toastNotification = toastNotification;
        }
        
        public IActionResult GetByUsername(string username)
        {
            var user = _userService.GetuserByUsername(username);            
            return View(user);
        }
        [HttpPost()]
        public IActionResult GetByUsername(UserVM model)
        {
            try
            {
                string uniqueFileName;
                int imgLength = ServiceHelper.ReturnImageLength(model.ProductType);
                if (model.Photos != null && model.Photos.Count > 0)
                {
                    foreach (IFormFile photo in model.Photos)
                    {
                        if (!ServiceHelper.IsItJpg(photo))
                        {
                            ViewBag.ImageError = "File must be jpg";
                            return View(model);
                        }
                        imgLength += 1;
                        string uploadFolder = Path.Combine(_env.WebRootPath, "images/Ideal_galery/" + model.ProductType);
                        uniqueFileName = String.Format("{0}-{1}.jpg", model.ProductType, imgLength);
                        string filePath = Path.Combine(uploadFolder, uniqueFileName);
                        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                       
                    }
                    _toastNotification.AddSuccessToastMessage($"images has been successfully updated");
                    Log.Debug($"images has been successfully updated");
                }
                else
                {
                    ViewBag.ImageError = "Please insert file";
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
             return RedirectToAction("index", "home");            
        }
        public IActionResult Login()
        {
            LoginVM model = new LoginVM(); 
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isAdmin;
                    Log.Debug($"Authenticating user with username: {model.Username}");
                    _userService.Login(model, out isAdmin);
                    if (isAdmin)
                    {
                        _toastNotification.AddSuccessToastMessage($"Welcome Boss - {model.Username}. Have a nice day!");
                        Log.Debug($"User with username {model.Username} successfully logged in!. Admin user");
                        return RedirectToAction("Products", "Product");
                    }
                    else
                    {
                        _toastNotification.AddWarningToastMessage("This log in is only for admin. Please don't try again! Thanks for understanding");
                        Log.Debug("Not admin user successfully rejected");
                        return RedirectToAction("Index", "Home");
                    }
                    
                }
               
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }
    }
}
