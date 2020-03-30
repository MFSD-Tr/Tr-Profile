using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using JWTAuthorisationApi.Token;
using JWTAuthorisationApi.Filter;
using BuisnessLayer.web.service;

namespace JWTAuthorisationApi.Controllers
{
    [RoutePrefix ("api/WebValue")]
    public class WebValueController : ApiController
    {

        [HttpGet, CustomAuthorisationFIlter,Route ("Get/{Value}")]
        public IHttpActionResult Get(string Value) {

            return Ok(new Service().GetValue (Value ));

        }

        [HttpPost,Route("ValidLogin")]
        public IHttpActionResult ValidLogin([FromUri]string UserName, [FromUri]string password)
        {


            if (UserName.Equals("dev") && password.Equals("12345"))
            {

                return Created(new Uri(Request.RequestUri.ToString()), TokenManager.GernateToken(UserName));

            }
            else
            {

                return StatusCode(HttpStatusCode.NotFound);

            }


        }
    }
}
