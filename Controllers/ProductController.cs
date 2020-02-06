using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_Test.WebUI.Entity;
using Task_Test.WebUI.Entity.Abstrac;

namespace Task_Test.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IproductRepstory IproductRepstory;
      
        private ICategoryRepstory CategoryRepstory;
        private ICityRepstory     CityRepstory;
        private IArrivalRepostory arrivalRepostory;
        private IDepartrueRepostory DepartrueRepostory;
        public ProductController(
            IproductRepstory IproductRepstory,
            ICategoryRepstory categoryRepstory,
            ICityRepstory cityRepstory,
            IArrivalRepostory arrivalRepostory,
            IDepartrueRepostory departrueRepostory)
        {
            this.IproductRepstory = IproductRepstory;
            this.CategoryRepstory = categoryRepstory;
            this.arrivalRepostory = arrivalRepostory;
            this.DepartrueRepostory = departrueRepostory;
            this.CityRepstory = cityRepstory;

        }
        public IActionResult Index(string q,string d)
        {

            var data = IproductRepstory.GetList()
                 .Include(x => x.Departrue)
                 .Include(x => x.Arrival)
                 .Include(x => x.Category)
                 .ToList();
            if (!string.IsNullOrEmpty(d))
            {
              DateTime dateTime=  Convert.ToDateTime(d);
                data = data.Where(i => i.Datetime.Value.Date==dateTime).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                data = data.Where(i => i.Name.ToUpper().Contains(q.ToUpper()) || i.Stok.ToString().Contains(q) || i.Kg.ToString().Contains(q) || i.Arrival.Name.ToUpper().Contains(q.ToUpper()) ||i.Category.Name.ToUpper().Contains(q.ToUpper())).ToList();
            }
            
            return View(data);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.cat = CategoryRepstory.GetList().AsEnumerable();
            ViewBag.cit = CityRepstory.GetList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Product product,string AName,string DName)
        {
            if (ModelState.IsValid)
            {
                Departrue dep = new Departrue();
                Arrival arrival = new Arrival();
                arrival.Name = AName;
                dep.Name = DName;
                if(await DepartrueRepostory.Add(dep))
                {
                   await arrivalRepostory.Add(arrival);
                }
                
                

                product.Departrueid = dep.Id;
                product.ArrivalId = arrival.Id;
                product.Datetime = DateTime.Now;
                if(!await IproductRepstory.Add(product))
                {
                        ModelState.AddModelError(",", "this error for IproductRepstory");
                }
                
                
                   
               
           
            
            return    RedirectToAction("Index");
            }
            
            return View();
        }
    }
}