using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebMVC.Controllers.Authorisation
{
    [RoutePrefix ("AuthTesting")]
    public class AuthTestingController : Controller
    {
        // GET: AuthTesting


        private static string WebURL = "";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TokenSaved() {

            var TypeOfAuth = Request.Cookies["TypeOfOAuth"].Value;
            String URL = "";
            ViewBag.type = TypeOfAuth;
            URL = "http://localhost:50104/AuthTesting/DisplayValue/{yourvalue}";
            ViewBag.URL = URL;
            return PartialView ();

        }

        [HttpGet,Route ("DisplayValue/{value}")]
        public async Task<ActionResult> DisplayValue(string id) {

            string BaseURL = "http://localhost:65163/api";

            if (Request.Cookies["TypeOfOAuth"].Value.Equals("OAuth"))
            {

                BaseURL = "http://localhost:60397/api";
                

            }
            
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applicaton/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Request.Cookies["Token"].Value);
                var response = await client.GetAsync("api/WebValue/Get/" + id);

                if (response.IsSuccessStatusCode)
                {

                    var result = response.Content.ReadAsStringAsync().Result;

                    ViewBag.DisplayedValue = JsonConvert.DeserializeObject<string>(result);

                }
                else {

                    ViewBag.DisplayedValue = "Error Formed In Server";

                }



            }
            return View();
            }

        }
    }