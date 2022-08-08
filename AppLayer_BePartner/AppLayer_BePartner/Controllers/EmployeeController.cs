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
    public class EmployeeController : ApiController
    {
        [Route("api/Employee/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = EmployeeService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Employee/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            id = id + ".com";
            var data = EmployeeService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Employee/create")]
        [HttpPost]
        public HttpResponseMessage Create(EmployeeModel s)
        {
            if (EmployeeService.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Employee/update")]
        [HttpPost]
        public HttpResponseMessage Update(EmployeeModel s)
        {
            if (EmployeeService.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Employee/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(string id)
        {
            id = id + ".com";
            if (EmployeeService.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
