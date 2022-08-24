using BLL.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SpadesGrocery.Controllers
{
    [EnableCors("*","*","*")]
    public class DeliveryScheduleController : ApiController
    {
        [Route("api/delivery/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = DeliveryScheduleService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/delivery/{id}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            var data = DeliveryScheduleService.GetById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/delivery/create")]
        [HttpPost]
        public HttpResponseMessage Create(DeliveryModel d)
        {
            var data = DeliveryScheduleService.Create(d);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/delivery/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = DeliveryScheduleService.Delete(id);
            if (data)
            {
                Redirect("api/delivery");
                return Request.CreateResponse(HttpStatusCode.OK, new { msg="OK",data=data});
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [Route("api/delivery/update")]
        [HttpPost]
        public HttpResponseMessage Update(DeliveryModel d)
        {
            var data = DeliveryScheduleService.Update(d);
            if (data)
            {
                Redirect("api/delivery");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, data);
        }
    }
}
