using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoMVCDemo.BackEnd.Helpers;
using UmbracoMVCDemo.BackEnd.Models;

namespace UmbracoMVCDemo.BackEnd.Controllers
{
    [PluginController("Demo")]
    [UmbracoAuthorize]
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

        public ActionResult Edit()
        {
            var demoObject = new DemoObject() {Id = 1, Description = "This is a demo object"};
            return View(demoObject);
        }

        [HttpPost]
        public ActionResult Edit(DemoObject demoObject)
        {
            if (demoObject != null && demoObject.Id == 1)
            {
                return RedirectToAction("Index");
            }
            return View("Error");
        }

    }
}
