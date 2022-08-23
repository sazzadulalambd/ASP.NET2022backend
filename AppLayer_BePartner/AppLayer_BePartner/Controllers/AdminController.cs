using BLL.Services;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppLayer_BePartner.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {

        [Route("api/Admin/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Admin/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            //id = id + ".com";
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Admin/create")]
        [HttpPost]
        public HttpResponseMessage Create(AdminModel s)
        {
            if (AdminService.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Admin/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminModel s)
        {
            if (AdminService.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/Admin/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            //id = id + ".com";
            if (AdminService.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
