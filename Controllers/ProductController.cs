using Microsoft.AspNetCore.Mvc;
using PetShop_EFCoreApiHW4.Models;

namespace PetShop_EFCoreApiHW4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [HttpPost]
        public void Add(Product product)
        {
            PetShopContext pr = new PetShopContext();
            pr.Products.Add(product);
            pr.SaveChanges();

        }
        [HttpGet]
        public IEnumerable<Product> GetProducts() => new PetShopContext().Products;
        

    }
}
