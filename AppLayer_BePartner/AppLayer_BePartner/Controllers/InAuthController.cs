
using BLL.Services;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace AppLayer_BePartner.Controllers
{
    public class InAuthController : ApiController
    {
        [Route("api/investor/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel obj)
        {
            var data = AuthServices.Authenticate(obj.Username, obj.Password);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [Route("api/investor/logout")]
        [HttpGet]
        public HttpResponseMessage Logout(TokenModel obj)
        {
            var data = AuthServices.Logout(obj.Tkey);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/alluser")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AuthServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
