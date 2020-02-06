using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Test_Task.WebUI.Infrastructure
{
    [HtmlTargetElement("input", Attributes ="colors")]
    public class InputTagHelper : TagHelper
    {
        public string btnColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        { 
            btnColor="danger";
            output.Attributes.SetAttribute("class", $"btn btn-{btnColor}");
           
        }
    }
   
}
