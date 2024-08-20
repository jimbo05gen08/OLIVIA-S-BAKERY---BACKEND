using Microsoft.AspNetCore.Mvc;
using OLIVIA_S_BAKERY___BACKEND.model;

namespace OLIVIA_S_BAKERY___BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("get")]
        public List<Product> GetProducts(int pageNumber)
        {
            var product = _context.Products.Skip((pageNumber - 1) * 4).Take(4).ToList();
            return product;
        }

        [HttpGet("get/{id}")]
        public Product GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }
    }
}
