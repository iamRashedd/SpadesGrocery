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
    public class ProductController : ApiController
    {
        [Route("api/products/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = ProductService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/products/{id}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            var data = ProductService.GetById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/products/filterbyname/{id}")]
        [HttpGet]
        public HttpResponseMessage FilterByName(string id)
        {
            var data = ProductService.FilterByName(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/products/filterbyprice/{id}")]
        [HttpGet]
        public HttpResponseMessage FilterByPrice(int id)
        {
            var data = ProductService.FilterByPrice(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/products/filterbyrating/{id}")]
        [HttpGet]
        public HttpResponseMessage FilterByRating(int id)
        {
            var data = ProductService.FilterByRating(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/products/create")]
        [HttpPost]
        public HttpResponseMessage Create(ProductModel p)
        {
            var data = ProductService.Create(p);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/products/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = ProductService.Delete(id);
            if (data)
            {
                Redirect("api/products");
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [Route("api/products/update")]
        [HttpPost]
        public HttpResponseMessage Update(ProductModel p)
        {
            var data = ProductService.Update(p);
            if (data)
            {
                Redirect("api/products");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, data);
        }
    }
}
