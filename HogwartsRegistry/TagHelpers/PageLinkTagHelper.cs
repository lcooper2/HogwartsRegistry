using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using HogwartsRegistry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.TagHelpers
{
    [HtmlTargetElement("div", Attributes="page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory; // MVC Routing used to create URL
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory; // Dependency injection
        }

        [ViewContext] // tag helper gains read access to the ViewContext
        [HtmlAttributeNotBound] // Limits the tag helper to readonly
        public ViewContext ViewContext { get; set; } // Wrapper for header information
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; } // Next or previous page?
        public string PageClass { get; set; } // set the initial class styles
        public string PageCLassNormal { get; set; } // applies to the first page
        public string PageClassSelected { get; set; } // applies to the selected page
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            // Dependency Injection
            TagBuilder results = new TagBuilder("div");
            for(int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                string url = PageModel.UrlParameters.Replace(":", i.ToString());
                tag.Attributes["href"] = url;
                tag.AddCssClass(PageClass);
                tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageCLassNormal);
                tag.InnerHtml.Append(i.ToString()); // text to display
                results.InnerHtml.AppendHtml(tag);
            }
            output.Content.AppendHtml(results.InnerHtml);
        }
    }
}
