using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
//using TracktiveDataObjectLayer.Web.DTO.Category;
using System.IO;
using Newtonsoft.Json;
using TracktiveDataObjectLayer.Web.DTO.Category;
using System.Net.Http.Formatting;
namespace TracktiveWebMVC.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet,Route("Category")]
        public  ActionResult Category()
        {

            return PartialView();

        }

        [HttpGet,Route("CategoryDashBoard")]
        public ActionResult CategoryDashBoard(long? categoryId)
        {
           
            return PartialView();

        }

        public ActionResult CategoryDashoboardProfile(long? categoryId)
        {

            return PartialView();

        }

        public ActionResult CategoryDashboardRate(long? catgeoryId)
        {
            return PartialView();
        }
        public ActionResult CategoryDashboardTiming(long? catgeoryId)
        {
            return PartialView();
        }


        public ActionResult ProjectDashoboardRate(int? projectId)
        {

            return PartialView();

        }

        public ActionResult CategoryDashBoardTimingTicketTable(long ? categoryId,string nosOfoRows="100")
        {

            ViewBag.row = Int64.Parse(nosOfoRows);
            return PartialView();

        }
      
    }
}