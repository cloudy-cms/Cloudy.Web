using Cloudy.CMS.ContentSupport;
using Cloudy.CMS.ContentTypeSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloudy.Web.Models
{
    [ContentType("b5417718-81a3-4d06-a5d7-c6b8b40915df")]
    public class BlogPage : IContent, IRoutable, IHierarchical, INameable
    {
        public string Id { get; set; }
        public string ContentTypeId { get; set; }
        public string UrlSegment { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        [UIHint("textarea")]
        public string Text { get; set; }
    }
}
