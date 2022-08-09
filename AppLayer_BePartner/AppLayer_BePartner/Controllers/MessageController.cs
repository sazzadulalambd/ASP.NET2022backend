using AppLayer_BePartner.Auth;
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
    public class MessageController : ApiController
    {
        [InValid]
        [Route("api/message/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = MessageServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/message/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = MessageServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/message/create")]
        [HttpPost]
        public HttpResponseMessage Create(MessageModel s)
        {
            if (MessageServices.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/message/update")]
        [HttpPost]
        public HttpResponseMessage Update(MessageModel s)
        {
            if (MessageServices.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/message/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            if (MessageServices.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/messenger/{id}")]
        [HttpGet]
        public HttpResponseMessage GetByEmail(string id)
        {
            id += ".com";
            var data = MessageServices.GetByEmail(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/message/delemail/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteByEmail(string id)
        {
            id += ".com";
            if (MessageServices.DeleteByEmail(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

    }
}
