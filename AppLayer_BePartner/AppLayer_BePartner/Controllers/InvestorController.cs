
using AppLayer_BePartner.Auth;
using BLL.Services;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AppLayer_BePartner.Controllers
{
    //[InValid]
    public class InvestorController : ApiController
    {
        [Route("api/investor/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = InvestorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/investor/at")]
        [HttpGet]
        public HttpResponseMessage Gett()
        {
            string authHeader = HttpContext.Current.Request.Headers["Authorization"];
            //var data = InvestorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, authHeader);
        }

        [Route("api/investor/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            id = id + ".com";
            var data = InvestorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/investor/create")]
        [HttpPost]
        public HttpResponseMessage Create(InvestorModel s)
        {
            if (InvestorService.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound,"Something went wrong");
        }

        [Route("api/investor/update")]
        [HttpPost]
        public HttpResponseMessage Update(InvestorModel s)
        {
            if (InvestorService.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/investor/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(string id)
        {
            id = id + ".com";
            if (InvestorService.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
