using Task_Test.WebUI.Entity.Abstrac;
using Task_Test.WebUI.Entity.Core;

namespace Task_Test.WebUI.Entity.Concreate
{
    public class ProductResptory : Baseresptory<Product>, IproductRepstory
    {
        public ProductResptory(MainDbContext context):base(context)
        {

        }
    }
}
