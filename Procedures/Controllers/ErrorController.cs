﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procedures.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/
        public ActionResult HttpError404()
        {
            return View("404");
        }
	}
}