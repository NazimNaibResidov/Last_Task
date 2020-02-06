using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.WebUI.Data;

namespace Test_Task.WebUI.Models
{
    public class RoleDetalis
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<ApplicationUser>  Memebers { get; set; }
        public IEnumerable<ApplicationUser> NonMemebers { get; set; }
    }
}
