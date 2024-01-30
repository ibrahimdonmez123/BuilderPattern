
using Microsoft.AspNetCore.Mvc;
using BuilderPattern.Product; 

namespace BuilderPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            IProductBuilder builder = new DefaultProductBuilder();

            ProductDirector director = new ProductDirector(builder);

            director.ConstructProduct("Laptop", "Elektronik", 1500);

            BuilderPattern.Product.Product product = builder.GetProduct(); 

            return product.ToString();
        }
    }
}
