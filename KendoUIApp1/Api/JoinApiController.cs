using KendoUIApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KendoUIApp1.Api
{
    public class JoinApiController : ApiController
    {
        private SQLLabEntities DB = new SQLLabEntities();

        [HttpGet]
        public IEnumerable<test1> GetAll()
        {
            return DB.test1;
        }
    }
}
