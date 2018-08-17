using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace MyAPI.Controllers
{
    //[EnableCorsAttribute("*","*","*"]
    public class TestController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage GetData()
        {
            List<customer> obj = new List<customer>();
            obj.Add(new customer { Firstname = "SINI" , company = "HEXAGON GLOBAL", Designation = "SOFTWARE ENGINEER" });
            return Request.CreateResponse(HttpStatusCode.Found, obj);
        }
    }
    public class customer
    {
        public string Firstname { get; set; }

        public string company { get; set; }

        public string Designation { get; set; }
    }
}
