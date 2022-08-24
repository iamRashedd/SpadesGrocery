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
    public class SalesAuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel user)
        {
            var data = SalesAuthService.Authenticate(user.username,user.password);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
        [Route("api/logout/")]
        [HttpGet]
        public HttpResponseMessage Logout(TokenModel tk)
        {
            var data = SalesAuthService.Logout(tk);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
