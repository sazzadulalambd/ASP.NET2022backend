using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayer_BePartner.Controllers
{
    public class IdeaController : ApiController
    {
        [Route("api/idea/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = IdeaServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
