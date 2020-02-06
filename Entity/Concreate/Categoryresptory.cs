using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Test.WebUI.Entity.Abstrac;
using Task_Test.WebUI.Entity.Core;

namespace Task_Test.WebUI.Entity.Concreate
{
    public class Categoryresptory:Baseresptory<Category>,ICategoryRepstory
    {

        public Categoryresptory(MainDbContext context):base(context)
        {

        }
    }
}
