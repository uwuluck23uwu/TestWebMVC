﻿using Microsoft.AspNetCore.Mvc;
using P01_MvcConcept.IService;

namespace P01_MvcConcept.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService ps;

        public ProductsController(IProductService ps) 
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetProductAll());
        }

        public IActionResult Create() 
        {
            return View();
        }

        //HttpPost ปลายทาง
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var result = ps.SearchProduct(product.Id);
            if (result == null)
            {
                ps.AddProduct(product);
            }
            return RedirectToAction("Index");
        }
    }
}
