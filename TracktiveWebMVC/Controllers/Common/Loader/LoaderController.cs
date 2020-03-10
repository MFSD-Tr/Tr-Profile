using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TracktiveWebMVC.Controllers.Common.Loader
{
    public class LoaderController : Controller
    {
        // GET: Loader
        public ActionResult Index(string Message,string ColorCode)
        {
            ViewBag.Message = Message;
            ViewBag.ColorCode = ColorCode;
            return PartialView();
        }

        
    }
}