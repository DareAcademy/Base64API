using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoC_UploadImage.data;

namespace PoC_UploadImage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        [Route("Insert")]
        public void Insert(Category obj)
        {
            PocContext context = new PocContext();
            context.Categories.Add(obj);
            context.SaveChanges();
        }

        [HttpGet]
        [Route("Load")]
        public IActionResult Load(int id)
        {
            PocContext context = new PocContext();
            var cat = context.Categories.Find(id);
            return Ok(new { name = "x.jpg", data = cat.Image });
        }
    }
}
