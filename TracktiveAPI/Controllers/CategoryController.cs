using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TracktiveBuisnessLayer.web.service.Category;
using TracktiveDataObjectLayer.Web.DTO.Category;

namespace TracktiveAPI.Controllers
{
    [RoutePrefix("api/Category")]
    public class CategoryController : ApiController
    {
        private CategoryService service;

        [HttpGet,Route("GetCategoryList/{ServiceName}")]
        public IHttpActionResult GetCategoryList(string ServiceName)
        {

            service = new CategoryService(ServiceName);

            

            return Ok(service.GetCategoryList());


        }
        [HttpGet,Route("GetCategoryProfile")]
        public IHttpActionResult  GetCategoryProfile(String ServiceName,long categoryId)
        {

            service = new CategoryService(ServiceName);

            return Ok(service.GetCategoryProfile(categoryId));

        }
        [HttpGet,Route("GetCategoryName")]
        public IHttpActionResult GetCategoryName(string ServiceName,long categoryId)
        {
            service = new CategoryService(ServiceName);
            return Ok(service.GetCategoryName(categoryId));
        }
    }
}
