using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            var model = new AboutViewModel()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View(model);
        }

        public AboutViewModel BuildModel(Item item)
        {
            var model = new AboutViewModel
            {
              ImagePosition = item.Fields["ImagePosition"]?.Value
            };

            return model;
        }
    }
}