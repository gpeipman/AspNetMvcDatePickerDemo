using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcDatePickerDemo.Models;

namespace AspNetMvcDatePickerDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new DummyModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(DummyModel model)
        {
            return Content(model.FromDate + "<br />" + model.ToDate);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}