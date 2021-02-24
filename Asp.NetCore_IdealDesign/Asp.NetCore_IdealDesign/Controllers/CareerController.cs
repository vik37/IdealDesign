using IdealDesign_Services.Helper;
using IdealDesign_Services.Interfaces;
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
    public class CareerController : Controller
    {
        private readonly ICareerService _career;
        private readonly IHostingEnvironment _env;
        private readonly IToastNotification _toastNotification;
        public CareerController(ICareerService career, IHostingEnvironment env, IToastNotification toastNotification)
        {
            _career = career;
            _env = env;
            _toastNotification = toastNotification;
        }

        [Route("Career/Applicants")]
        public IActionResult Index()
        {
            var careers = _career.GetAll().ToList();
            return View(careers);
        }
        public IActionResult Detail(int id)
        {
            try
            {
                var career = _career.GetById(id);
                string file = _career.GetFilename(career.Id);
                ViewBag.file = file;
                return View(career);
            }
            catch (Exception ex)
            {
                Log.Error($"{ex.Message} | {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
       
        public IActionResult Create()
        {
            _toastNotification.AddInfoToastMessage("For a job application, all fields must be filled out.");
            CareerVM model = new CareerVM();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CareerVM model)
        {         
            try
            {
                if (ModelState.IsValid)
                {
                    var allResume = _career.GetAllResumes().ToList();
                    if(model.Resume != null)
                    {
                        foreach(var resume in allResume)
                        {
                            if(model.Resume.FileName == resume)
                            {
                                ViewBag.errorResumeMsg = "Can not upload same resume!";
                                return View(model);
                            }
                        }
                        string uploadFolder = Path.Combine(_env.WebRootPath, "data/resumes");
                        string uniqueFilename = model.Resume.FileName;
                        string filePath = Path.Combine(uploadFolder, uniqueFilename);
                        string extension = Path.GetExtension(filePath);

                        if (!ServiceHelper.IsItDocument(model.Resume))
                        {
                            ViewBag.errorUploadMsg = "Only Microsoft word and pdf files allowed.";
                        }
                        else
                        {
                            model.Resume.CopyTo(new FileStream(filePath, FileMode.Create));                       
                            _career.CreateCareer(model);
                            _toastNotification.AddSuccessToastMessage("the application has been successfully submitted. " +
                                                "Thank you and after reviewing your application, we will send you an answer.");
                            return RedirectToAction("index", "home");
                        }
                    }
                }               
            }
            catch (Exception ex)
            {

                Log.Error($"{ex.Message}");
            }          
            return View(model);
        }
        public IActionResult DeleteById(int id)
        {
            try
            {
                var career = _career.GetById(id);
                return View(career);
            }
            catch (Exception ex)
            {

                Log.Error($"{ex.Message} | {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var career = _career.GetById(id);
                string filename = _career.GetFilename(career.Id);
                string directory = Path.Combine(_env.WebRootPath, "data/resumes");
                string fullPath = Path.Combine(directory, filename);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                    _career.RemoveCareer(career.Id);
                    _toastNotification.AddSuccessToastMessage("Deleted is successfully!");
                    return RedirectToAction("Applicants", "Career");
                }
            }
            catch (Exception ex)
            {

                Log.Error($"{ex.Message} | {ex.InnerException}");
            }

            return PartialView("ErrorView");
        }
    }
}
