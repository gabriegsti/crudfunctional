using CrudFucntional.Data;
using CrudFucntional.Model;
using Microsoft.AspNetCore.Mvc;

namespace CrudFucntional.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly SqlServerEFDbContext _context;
        public ProductController(SqlServerEFDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Addproduct([FromBody] Product product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}