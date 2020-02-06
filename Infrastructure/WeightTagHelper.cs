using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Test.WebUI.Infrastructure
{
    [HtmlTargetElement("td", Attributes = "weight-siz")]
    public class WeightTagHelper:TagHelper
    {
        [HtmlAttributeName("weight-siz")]
        public int Weight { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Weight>1000)
            {
                int count = Weight / 1000;
                output.Content.SetContent(count.ToString() + " Tone ");
            }
            else if(Weight<1000)
            {
                output.Content.SetContent(Weight + " Kg ");
            }
        }
    }
}
