﻿using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIApp1.Controllers
{
    public class JoinController : Controller
    {
        // GET: Join
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test_Read([DataSourceRequest]DataSourceRequest )
        {
            return View();
        }
    }
}