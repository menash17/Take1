using OrderMe.WebServerContract.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderMeWebServer.Controllers.Restaurant
{
    public class OrderController : ApiController
    {
        [Route("Restaurant/Order")]
        [HttpPost]
        public HttpResponseMessage Order(OrderRequest orderRequest)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
