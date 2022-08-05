﻿using BLL.Entities;
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

        [Route("api/idea/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = IdeaServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/idea/create")]
        [HttpPost]
        public HttpResponseMessage Create(IdeaModel s)
        {
            if (IdeaServices.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/idea/update")]
        [HttpPost]
        public HttpResponseMessage Update(IdeaModel s)
        {
            if (IdeaServices.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/idea/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            if (IdeaServices.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/idea/email/{id}")]
        [HttpGet]
        public HttpResponseMessage GetByEnEmail(string id)
        {
            id = id + ".com";
            var data = IdeaServices.GetByEnEmail(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/idea/myinvestment/{id}")]
        [HttpGet]
        public HttpResponseMessage MyInvestment(string id)
        {
            id = id + ".com";
            var data = IdeaServices.MyInvestment(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}