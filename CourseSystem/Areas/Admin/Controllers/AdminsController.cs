using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseSystem.Models;

namespace CourseSystem.Areas.Admin.Controllers
{
    public class AdminsController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


    }
}
