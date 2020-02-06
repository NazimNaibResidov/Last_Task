using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Test.WebUI.Entity.Abstrac;

namespace Task_Test.WebUI.Entity.Core
{
   public interface IUnitOfWork:IDisposable
    {
         ICategoryRepstory categoryRepstory { get; }
         IproductRepstory  productRepstory { get; }
      
         ICityRepstory     cityRepstory { get; }
    }
}
