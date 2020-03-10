using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TracktiveWebMVC.Models.Category;
using TracktiveWebMVC.Models;
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
        public async System.Threading.Tasks.Task<ActionResult> Category(string categoryName)
        {

            //CategoryProfileViewModel model = new CategoryProfileViewModel();

            CategoryViewModel model = new CategoryViewModel();

            //model.CategoryFirstCard.Value =

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61631/");
                //getting CountryList
                HttpResponseMessage response = await client.GetAsync("api/Category/GetCategoryList/"+ categoryName);
                if (response.IsSuccessStatusCode)
                { 
                   model.CategoryListModel = response.Content.ReadAsAsync<List<CategoryDTO>>().Result;
                    Session["categoryName"] = categoryName;
                }

                
            }
            return PartialView(model);

        }

        [HttpGet,Route("CategoryDashBoard")]
        public async System.Threading.Tasks.Task<ActionResult> CategoryDashBoard(long? categoryId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61631/");
                //getting CountryList
                HttpResponseMessage response = await client.GetAsync("api/Category/GetCategoryName?ServiceName=" + Session["categoryName"].ToString() + "&categoryId=" + categoryId);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.CategoryName = response.Content.ReadAsAsync<string >().Result;
                    ViewBag.CategoryId = categoryId;
                }


            }
            return PartialView();

        }

        public async System.Threading.Tasks.Task<ActionResult> CategoryDashoboardProfile(long? categoryId)
        {
            CategoryViewModel model = new CategoryViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61631/");
                //getting CountryList
                HttpResponseMessage response = await client.GetAsync("api/Category/GetCategoryProfile?ServiceName="+ Session["categoryName"].ToString() + "&categoryId=" + categoryId);
                if (response.IsSuccessStatusCode)
                {
                   model.categoryProfileModel = response.Content.ReadAsAsync<CategoryProfileDTO>().Result;
                }


            }
            return PartialView(model);

        }
        public ActionResult ProjectDashoboardRate(int? projectId)
        {

            return PartialView();

        }

      
    }
}