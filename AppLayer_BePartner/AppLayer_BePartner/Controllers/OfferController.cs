using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayer_BePartner.Controllers
{
    public class OfferController : ApiController
    {
        [Route("api/offer/get/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = OfferServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/offer/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = OfferServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/offer/create")]
        [HttpPost]
        public HttpResponseMessage Create(OfferModel s)
        {
            if (OfferServices.Create(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data inserted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/offer/update")]
        [HttpPost]
        public HttpResponseMessage Update(OfferModel s)
        {
            if (OfferServices.Update(s))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data updated");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/offer/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            if (OfferServices.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }

        [Route("api/offer/sentoffer/{id}")]
        [HttpGet]
        public HttpResponseMessage MySentOffer(string id)
        {
            id += ".com";
            var data = OfferServices.MySentOffer(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/offer/deletebymail/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteByInEmail(string id)
        {
            id += ".com";
            if (OfferServices.DeleteByInEmail(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
