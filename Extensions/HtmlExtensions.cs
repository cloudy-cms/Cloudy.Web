using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Cloudy.Web.Extensions
{
    public static class HtmlExtensions
    {
        public static IHtmlContent AddParagraphs(this IHtmlHelper htmlHelper, string value)
        {
            if(value == null)
            {
                return null;
            }

            return htmlHelper.Raw("<p>" + value.Replace("\n", "</p><p>") + "</p>");
        }
    }
}
