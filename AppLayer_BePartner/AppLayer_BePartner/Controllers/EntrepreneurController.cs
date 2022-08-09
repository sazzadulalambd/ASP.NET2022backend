using Entity;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayer_BePartner.Controllers
{
    public class EntrepreneurController : ApiController
    {
        [Route("api/Entrepreneur/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = EntrepreneurService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Entrepreneur/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            id = id + ".com";
            var data = EntrepreneurService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Entrepreneur/create")]
        [HttpPost]
        public HttpResponseMessage Create(EntrepreneurModel s)
        {
            if (EntrepreneurService.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Entrepreneur/update")]
        [HttpPost]
        public HttpResponseMessage Update(EntrepreneurModel s)
        {
            if (EntrepreneurService.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Entrepreneur/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(string id)
        {
            id = id + ".com";
            if (EntrepreneurService.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
