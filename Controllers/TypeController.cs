using Microsoft.AspNetCore.Mvc;
using PetShop_EFCoreApiHW4.Models;

namespace PetShop_EFCoreApiHW4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeController : Controller
    {
        [HttpPost]
        public void Add(Type_ type)
        {
            PetShopContext pr = new PetShopContext();

            pr.Types.Add(type);
            pr.SaveChanges();

        }
        [HttpGet]
        public IEnumerable<Type_> GetType_() => new PetShopContext().Types;
    }
}
