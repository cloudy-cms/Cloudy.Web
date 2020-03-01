using Cloudy.CMS.ContentSupport;
using Cloudy.CMS.ContentTypeSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloudy.Web.Models
{
    [ContentType("157d1342-8ae6-4718-9127-2484425e0666")]
    public class HelpSection : IContent
    {
        public string Id { get; set; }
        public string ContentTypeId { get; set; }

        public string Name { get; set; }
        public string Heading { get; set; }
        [UIHint("azureblobimage")]
        public string Image { get; set; }
        [UIHint("textarea")]
        public string Text { get; set; }
        [UIHint("textarea")]
        public string Code { get; set; }
    }
}
