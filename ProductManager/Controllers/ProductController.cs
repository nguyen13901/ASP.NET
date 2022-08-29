using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Services;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _iProductService;
        public ProductController(IProductService iProductService)
        {
            this._iProductService = iProductService;
        }
        public IActionResult Index()
        {
            // ViewBag.Categories = Categories;
            // ViewData["Categories"] = Categories;
            var products = _iProductService.GetProducts();
            return View(products);
        }

    }

}