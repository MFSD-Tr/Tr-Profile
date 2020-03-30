using BuisnessLayer.web.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TractiveWebApi.Controllers
{
    [Authorize,RoutePrefix ("api/WebValue")]

    public class WebValueController : ApiController
    {
        // GET api/WebApi  
        [Route ("Get/{DisplayValue}")]
        public IHttpActionResult  Get(string DisplayValue)
        {
            return Ok (new Service().GetValue (DisplayValue));
        }

        
    }
}
