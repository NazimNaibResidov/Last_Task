using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_Test.WebUI.Entity.Abstrac;

namespace Task_Test.WebUI.Controllers
{
    public class CitryController : Controller
    {
        private readonly ICityRepstory cityRepstory;
        public CitryController(ICityRepstory cityRepstory)
        {
            this.cityRepstory = cityRepstory;
        }
        public IActionResult Index()
        {
            return View(cityRepstory.GetList().AsEnumerable());
        }
    }
}