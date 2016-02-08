using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseController.Models.BaseModels
{
    public class Site
    {
        public int SiteID { get; set; }
        public string LinkName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}