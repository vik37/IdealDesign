
using IdealDesign_Domain.Enums;
using IdealDesign_Services.Helper;
using IdealDesign_Services.Interfaces;
using IdealDesign_WebModels.EnumsVM;
using IdealDesign_WebModels.VewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using NToastNotify;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace Asp.NetCore_IdealDesign.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IToastNotification _toastNotification;
        private readonly IStringLocalizer<ProductController> _localizer;
        
        public ProductController(IProductService productService, IToastNotification toastNotification,
            IStringLocalizer<ProductController> localizer)
        {
            _productService = productService;
            _toastNotification = toastNotification;           
            _localizer = localizer;
        }
       
        public IActionResult Products()
        {                        
            List<ProductVM> products = _productService.GetAllProducts().ToList();
            ViewBag.bathroom = _localizer["Bathroom Furniture"];
            ViewBag.living = _localizer["Living Room Furniture"];
            ViewBag.wall = _localizer["Wall Beds"];
            ViewBag.child = _localizer["Childrens Furniture"];
            ViewBag.btnLog = _localizer["My Home"];
            return View(products);
        }
        
        public IActionResult ProductType(ProductTypeVM type)
        {
            try
            {
                switch (type)
                {
                    case ProductTypeVM.Kitchens:
                        ViewBag.type = _localizer[ServiceHelper.GetDescription(ProductTypeVM.Kitchens)];
                        break;
                    case ProductTypeVM.Wardrobes:
                        ViewBag.type = _localizer[ServiceHelper.GetDescription(ProductTypeVM.Wardrobes)];
                        break;
                    case ProductTypeVM.BathroomFurniture:
                        ViewBag.type = _localizer[ServiceHelper.GetDescription(ProductTypeVM.BathroomFurniture)];
                        break;
                    case ProductTypeVM.LivingRoomFurniture:
                        ViewBag.type = _localizer[ServiceHelper.GetDescription(ProductTypeVM.LivingRoomFurniture)];
                        break;
                    case ProductTypeVM.WallBeds:
                        ViewBag.type = 
                           _localizer[ServiceHelper.GetDescription(ProductTypeVM.WallBeds)];
                        break;
                    case ProductTypeVM.ChildrensFurniture:
                        ViewBag.type = ServiceHelper.GetDescription(ProductTypeVM.ChildrensFurniture);
                        break;
                    case ProductTypeVM.Other:
                        ViewBag.type = _localizer[ServiceHelper.GetDescription(ProductTypeVM.Other)];
                        break;
                    default:
                        RedirectToAction("Product/ProductType?type=Kitchens");
                        break;
                }

                ViewBag.imgLength = ServiceHelper.ReturnImageLength(type);
                ViewBag.productType = type;
                var products = _productService.GetProductByType((ProductTypes)type).ToList();            
                return View(products);
            }
            catch (Exception ex)
            {

                Log.Error($"{ex.Message}");
            }
            return PartialView("ErrorView");
        }
        public ActionResult Galery()
        {
            try
            {
                ViewBag.imgKitchensLength = ServiceHelper.ReturnImageLength(ProductTypeVM.Kitchens);
                ViewBag.Kitchens = ProductTypeVM.Kitchens;
                ViewBag.imgWardrobesLength = ServiceHelper.ReturnImageLength(ProductTypeVM.Wardrobes);
                ViewBag.Wardrobes = ProductTypeVM.Wardrobes;
                ViewBag.imgBathroomFurnitureLength = ServiceHelper.ReturnImageLength(ProductTypeVM.BathroomFurniture);
                ViewBag.BathroomFurniture = ProductTypeVM.BathroomFurniture;
                ViewBag.imgLivingRoomFurnitureLength = ServiceHelper.ReturnImageLength(ProductTypeVM.LivingRoomFurniture);
                ViewBag.LivingRoomFurniture = ProductTypeVM.LivingRoomFurniture;
                ViewBag.imgWallBedsLength = ServiceHelper.ReturnImageLength(ProductTypeVM.WallBeds);
                ViewBag.WallBeds = ProductTypeVM.WallBeds;
                ViewBag.imgChildrensFurnitureLength = ServiceHelper.ReturnImageLength(ProductTypeVM.ChildrensFurniture);
                ViewBag.ChildrensFurniture = ProductTypeVM.ChildrensFurniture;
                ViewBag.imgOtherLength = ServiceHelper.ReturnImageLength(ProductTypeVM.Other);
                ViewBag.Other = ProductTypeVM.Other;
            }
            catch (Exception ex)
            {
                Log.Error($"{ex.Message}");
            }
            
            return View();
        }       
    }    
}
