using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace UmbracoMVCDemo.FrontEnd.Controllers
{
    public class DemoController : Umbraco.Web.Mvc.RenderMvcController
    {
        //
        // GET: /Demo/

        public override ActionResult Index(RenderModel model)
        {
            //Do some stuff here, then return the base method
            return base.Index(model);
        }

        public ActionResult Demo(RenderModel model)
        {
            return View(model);
        }

    }
}
