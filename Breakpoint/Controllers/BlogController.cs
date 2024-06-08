using Microsoft.AspNetCore.Mvc;

namespace Breakpoint.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(int id)
        {
            if(id == 0)
            {
                id = 20;
            }
            int x = id;
            int y = x + 10;
            int z = y + x;
            return Content(z.ToString());
        }
    }
}
