using SimpleMath.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleMath.App.Controllers
{
    public class OperationController : ApiController
    {
        [HttpGet]
        public Operation Summa(int a, int b)
        {
            return new Operation()
            {
                a = a,
                b = b,
                summa = a + b
            };
        }
    }
}
