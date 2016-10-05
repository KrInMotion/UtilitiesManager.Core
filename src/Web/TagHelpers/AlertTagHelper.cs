using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.TagHelpers
{
    [HtmlTargetElement("alert")]
    public class AlertTagHelper : TagHelper
    {
        [HtmlAttributeName("alert-type")]
        public string Type { get; set; }

        [HtmlAttributeName("dismissable")]
        public bool Dismissable { get; set; }

        [HtmlAttributeName("message")]
        public string Message { get; set; }

        [HtmlAttributeName("icon")]
        public bool Icon { get; set; }

        public override void Init(TagHelperContext context)
        {
            base.Init(context);
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var content = string.Empty;
            var classStyle = $"alert alert-{Type} fade in";
            if (Dismissable) classStyle += " alert-dismissable";
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", classStyle);
            if (Dismissable)
            {
                content += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>";
            }
            if (Icon)
            {
                var faIcon = string.Empty;
                switch (Type)
                {
                    case "info": faIcon = "fa-info"; break;
                    case "warning": faIcon = "fa-warning"; break;
                    case "danger": faIcon = "fa-close"; break;
                    case "success": faIcon = "fa-check"; break;
                    default: faIcon = "fa-info"; break;
                }
                content += $"<i class=\"fa fa-fw {faIcon}\"></i>";
            }
            content += $"<span>{Message}</span>";
            output.Content.SetHtmlContent(content);
            base.Process(context, output);
        }
    }
}