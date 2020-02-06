using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.WebUI.Data;

namespace Test_Task.WebUI.Infrastructure
{
    [HtmlTargetElement("td",Attributes = "identity-Role")]
    public class RoleUserTagHelper:TagHelper
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> UserManager;

        public RoleUserTagHelper(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> UserManager)
        {
            this.UserManager = UserManager;
            this.roleManager = roleManager;
        }
        [HtmlAttributeName("identity-Role")]
        public string Role { get; set; }
        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();
            var role = await roleManager.FindByIdAsync(Role);
            if (role!=null)
            {
                foreach (var item in UserManager.Users)
                {
                    if (item!=null&&await UserManager.IsInRoleAsync(item,role.Name))
                    {
                        names.Add(item.UserName);
                    }
                }
            }
            output.Content.SetContent(names.Count == 0 ? "No User" : string.Join(",", names));
        }
    }
   
}
