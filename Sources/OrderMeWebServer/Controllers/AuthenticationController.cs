using OrderMe.WebServerContract.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderMeWebServer.Controllers
{
    public class AuthenticationController : ApiController
    {
        [Route("Login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginRequest loginRequest)
        {
            AuthenticationResult authenticationResult = new AuthenticationResult();
            return Request.CreateResponse(HttpStatusCode.OK, authenticationResult);
        }
    }
}
