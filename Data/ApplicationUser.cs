using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task.WebUI.Data
{
    public class ApplicationUser:IdentityUser
    {
        public bool IsActive { get; set; }
    }
}
