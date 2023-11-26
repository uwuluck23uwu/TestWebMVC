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
            if (!ModelState.IsValid) { return View(); }
            var result = ps.SearchProduct(product.Id);
            if (result == null)
            {
                ps.AddProduct(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) 
        {
            ps.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) 
        {
            var result = ps.SearchProduct(id);
            if (result == null) { return RedirectToAction("Index"); }
            return View(result);
        }

        [HttpPut]
        public IActionResult Edit(Product product) 
        {
            if (!ModelState.IsValid) { return View(); }
            ps.UpdateProduct(product);
            return RedirectToAction("Index");
        }
    }
}
