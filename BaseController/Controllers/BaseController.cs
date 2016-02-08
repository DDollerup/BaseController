using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseController.Models.BaseModels;
using BaseController.Models.ViewModels;

namespace BaseController.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            LayoutModel lm = new LayoutModel()
            {
                Sites = new List<Site>()
                {
                    new Site() { SiteID = 1, LinkName = "Home", Action = "Index", Controller = "Home" },
                    new Site() { SiteID = 1, LinkName = "About", Action = "About", Controller = "Home" },
                    new Site() { SiteID = 1, LinkName = "Contact", Action = "Contact", Controller = "Home" }
                }
            };

            ViewBag.LayoutModel = lm;
        }
    }
}