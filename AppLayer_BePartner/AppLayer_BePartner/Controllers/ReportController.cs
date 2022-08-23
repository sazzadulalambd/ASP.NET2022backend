using BLL.Services;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayer_BePartner.Controllers
{
    public class ReportController : ApiController
    {
        [Route("api/Report/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ReportService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Report/Recived/{id}")]
        [HttpPost]
        public HttpResponseMessage recivedByEmails(string email)
        {
            email = email+".com";
            var data = ReportService.recivedByEmails(email);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Report/send/{id}")]
        [HttpGet]
        public HttpResponseMessage sendByEmails(string email)
        {
            email = email+ ".com";
            var data = ReportService.sendByEmails(email);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Report/create")]
        [HttpPost]
        public HttpResponseMessage Create(ReportModel s)
        {
            if (ReportService.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Report/update")]
        [HttpPost]
        public HttpResponseMessage Update(ReportModel s)
        {
            if (ReportService.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Report/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            
            if (ReportService.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
