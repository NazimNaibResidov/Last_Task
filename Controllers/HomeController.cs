using Microsoft.AspNetCore.Mvc;

namespace Test_Task.WebUI.Controllers
{
    public class HomeController : Controller
    {
       
        
        public IActionResult Index()
        {
            return View();
        }
    }
}