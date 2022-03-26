using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FakeBD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post( Tags Data)
        {
            return 
        }
    }
}
