using Cloudy.CMS.ContentSupport;
using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.UI.FormSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloudy.Web.Models
{
    [ContentType("157d1342-8ae6-4718-9127-2484425e0666")]
    public class HelpSection : IContent, INameable, IRoutable
    {
        public string Id { get; set; }
        public string ContentTypeId { get; set; }
        [Display(GroupName = null)]
        public string UrlSegment { get; set; }

        public string Name { get; set; }
        public string Heading { get; set; }
        [UIHint("azureblobimage")]
        public ImageReference Image { get; set; }
        [UIHint("textarea({rows:3})")]
        public string Text { get; set; }
        public IEnumerable<ActionButton> Actions { get; set; }

        [Form("126dac6a-6dc4-4208-9f35-772342714e8b")]
        public class ImageReference
        {
            [Display(Name = "URL")]
            public string Src { get; set; }
            [Display(Name = "Alternate text")]
            public string Alt { get; set; }
        }

        [Form("4f470d9b-5006-4235-868d-d7b22ffd0e95")]
        public class ActionButton
        {
            public string Id { get; set; }
            public string Text { get; set; }
        }
    }
}
