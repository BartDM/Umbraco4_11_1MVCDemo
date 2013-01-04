using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace UmbracoMVCDemo.BackEnd.Controllers
{
    [PluginController("Demo")]
    public class DemoAdminSurfaceController : SurfaceController 
    {

        public DemoAdminSurfaceController()
        {
            
        }

        public DemoAdminSurfaceController(UmbracoContext umbracoContext)
            : base(umbracoContext)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
