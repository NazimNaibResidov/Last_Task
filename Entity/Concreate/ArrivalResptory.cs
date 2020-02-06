using Task_Test.WebUI.Entity.Abstrac;
using Task_Test.WebUI.Entity.Core;

namespace Task_Test.WebUI.Entity.Concreate
{
    public class ArrivalResptory:Baseresptory<Arrival>,IArrivalRepostory
    {
        public ArrivalResptory(MainDbContext context):base(context)
        {

        }
    }
}
