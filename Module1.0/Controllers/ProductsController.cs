using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(){ProductId =1, ProductName="Laptop", ProductPrice = "200"},
            new Product(){ProductId =2, ProductName="Smart Phone", ProductPrice = "100"}
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
        [HttpPost]
        public void Post(Product p)
        {
            products.Add(p);
        }

    }
}