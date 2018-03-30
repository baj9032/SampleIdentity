using SampleWeb.DBContext;
using SampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWeb.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var authors = unitOfWork.Authors;
            }

            return View();
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