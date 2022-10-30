using Microsoft.AspNetCore.Mvc;
using PetShop_EFCoreApiHW4.Models;

namespace PetShop_EFCoreApiHW4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManufacturerController : Controller
    {
        [HttpPost]
        public void Add(Manufacturer manufacturer)
        {
            PetShopContext pr = new PetShopContext();
            pr.Manufacturers.Add(manufacturer);
            pr.SaveChanges();

        }
        [HttpGet]
        public IEnumerable<Manufacturer> GetManufacturer() => new PetShopContext().Manufacturers;
    }
}
