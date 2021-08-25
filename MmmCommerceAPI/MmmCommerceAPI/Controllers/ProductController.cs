using Microsoft.AspNetCore.Mvc;
using MmmCommerceAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProductById(Guid id)
        {
            return new ProductDto { ProductId = new Guid(), Description = "test item", Name = "My First Product", Price = 19.99, Materials = new[] { "Plastic", "Wood", "Leather" } };
        }

        [HttpGet]
        public ActionResult<List<ProductDto>> GetProducts(string? name, string? tag, string? material)
        {
            var list = new List<ProductDto> {
                new ProductDto { ProductId = new Guid(), Description = "test item", Name = "My First Product", Tags = new[] {"", "" }, Price = 19.99, Materials = new[] { "Plastic", "Wood", "Leather" }},
                new ProductDto { ProductId = new Guid(), Description = "test item", Name = "My Second Product", Tags = new[] {"", "" }, Price = 19.99, Materials = new[] { "Plastic", "Wood", "Leather" }},
                new ProductDto { ProductId = new Guid(), Description = "test item", Name = "My Third Product", Tags = new[] {"", "" }, Price = 19.99, Materials = new[] { "Plastic", "Wood", "Leather" }}
            };

            return list;
        }


        [HttpPost]
        public ActionResult<ProductDto> AddNewProduct([FromBody] string name, [FromBody] string description, [FromBody] double price)
        {
            return new ProductDto { ProductId = new Guid(), Description = description, Name = name, Price = price, };
        }


        /// <summary>
        /// Update all values of the product 
        /// </summary>
        /// <returns></returns>
        [HttpPut("{product_id}")]
        public ActionResult<ProductDto> UpdateProduct(ProductDto product)
        {
            return new ProductDto();// { ProductId = new Guid(), Description = description, Name = "My First Product", Price = price, };
        }
    }
}
