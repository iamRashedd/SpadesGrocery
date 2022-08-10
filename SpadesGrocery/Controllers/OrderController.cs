using BLL.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpadesGrocery.Controllers
{
    public class OrderController : ApiController
    {

        [Route("api/orders/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = OrderService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/orders/{id}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            var data =OrderService.GetById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders/create")]
        [HttpPost]
        public HttpResponseMessage Create(OrderModel o)
        {
            var data = OrderService.Create(o);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = OrderService.Delete(id);
            if (data)
            {
                Redirect("api/orders");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [Route("api/orders/update")]
        [HttpPost]
        public HttpResponseMessage Update(ProductModel p)
        {
            var data = OrderService.Update(p);
            if (data)
            {
                Redirect("api/orders");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, data);
        }

    }
}