using Task_Test.WebUI.Entity.Abstrac;
using Task_Test.WebUI.Entity.Core;

namespace Task_Test.WebUI.Entity.Concreate
{
    public class DepartrueResptory : Baseresptory<Departrue>, IDepartrueRepostory
    {
        public DepartrueResptory(MainDbContext context):base(context)
        {

        }
    }
}
