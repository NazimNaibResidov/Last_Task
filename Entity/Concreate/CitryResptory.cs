using Task_Test.WebUI.Entity.Abstrac;
using Task_Test.WebUI.Entity.Core;

namespace Task_Test.WebUI.Entity.Concreate
{
    public class CitryResptory : Baseresptory<City>, ICityRepstory
    {
        public CitryResptory(MainDbContext context):base(context)
        {

        }
    }
}
