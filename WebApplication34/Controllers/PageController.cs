using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApp.Controllers
{
    public class PageController : Controller
    {
       
        public IActionResult Greet(string name)
        {
            return View("Greet", name); 
        }
    }
}
