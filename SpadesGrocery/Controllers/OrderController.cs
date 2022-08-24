using BLL.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web;

namespace SpadesGrocery.Controllers
{
    [EnableCors("*","*","*")]
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
        [Route("api/orders/details/{id}")]
        [HttpGet]
        public HttpResponseMessage DetailsById(int id)
        {
            var data = OrderService.DetailsById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/orders/allapproved/")]
        [HttpGet]
        public HttpResponseMessage AllApproved()
        {
            var data = OrderService.AllApproved();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/orders/allcanceled/")]
        [HttpGet]
        public HttpResponseMessage AllCanceled()
        {
            var data = OrderService.AllCanceled();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders/approve/{id}")]
        [HttpGet]
        public IHttpActionResult ApproveById(int id)
        {
            var data = OrderService.ApproveById(id);
            return Redirect("https://localhost:44340/api/orders/");
            //return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/orders/cancel/{id}")]
        [HttpGet]
        public IHttpActionResult CancelById(int id)
        {
            var data = OrderService.CancelById(id);
            return Redirect("https://localhost:44340/api/orders/");
            //return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders/filteredbydate/{id}")]
        [HttpGet]
        public HttpResponseMessage FilteredByDate(string id)
        {
            var data = OrderService.FilteredByDate(id);
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
        public IHttpActionResult Delete(int id)
        {
            var data = OrderService.Delete(id);
            
            return Redirect("https://localhost:44340/api/orders/");
            //return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [Route("api/orders/update")]
        [HttpPost]
        public IHttpActionResult Update(OrderModel p)
        {
            var data = OrderService.Update(p);

            return Redirect("https://localhost:44340/api/orders/");
        }

    }
}