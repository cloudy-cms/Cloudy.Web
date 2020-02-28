using Cloudy.CMS.ContentSupport;
using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.SingletonSupport;
using Poetry.UI.FormSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudyWeb.Models
{
    [Display(Name = "Start page")]
    [Singleton("3664d115-2000-4d77-af7f-0a72dd6dca9b")]
    [ContentType("fa07d535-c10c-44a2-ac75-666f33ffa9f2")]
    public class StartPage : IContent, IRoutable, IHierarchical, INameable
    {
        public string Id { get; set; }
        public string ContentTypeId { get; set; }
        public string UrlSegment { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }

        public string WindowTitle { get; set; }
        public string Heading { get; set; }
        [UIHint("textarea")]
        public string Intro { get; set; }
        public List<Usp> Usps { get; set; }
        public string Legal { get; set; }

        [Form("usp")]
        public class Usp
        {
            public string Heading { get; set; }
            [UIHint("textarea")]
            public string Text { get; set; }
        }
    }
}
