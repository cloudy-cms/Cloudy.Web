﻿using Cloudy.CMS.ModelBinding;
using Cloudy.CMS.SingletonSupport;
using Cloudy.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudyWeb.Controllers
{
    public class ContentController : Controller
    {
        ISingletonGetter SingletonGetter { get; }

        public ContentController(ISingletonGetter singletonGetter)
        {
            SingletonGetter = singletonGetter;
        }

        public async Task<ActionResult> StartPage()
        {
            var page = await SingletonGetter.GetAsync<StartPage>(null);

            return View("StartPage", page);
        }

        public ActionResult HelpSection([FromContentRoute] HelpSection content)
        {
            return Json(content);
        }
    }
}
