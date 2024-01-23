using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jobify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public string CategoryPost(string name)
        {
            return "Your name is "+name;
        }

        [HttpGet]
        public string CategoryGet()
        {
            return "Category Price 100";
        }
    }
}
