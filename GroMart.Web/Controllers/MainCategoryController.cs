using GroMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroMart.Web.Controllers
{
    public class MainCategoryController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MainCategory maincategory)
        {
            return View();
        }
    }
}