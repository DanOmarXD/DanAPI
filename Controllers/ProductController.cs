using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, ProductName = "Laptop" },
            new Product { Id = 2, ProductName = "Phone" }
        };
    }
}
