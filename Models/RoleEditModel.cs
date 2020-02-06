using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task.WebUI.Models
{
    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string [] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}
