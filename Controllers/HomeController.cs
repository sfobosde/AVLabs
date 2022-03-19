using AVLabWeb.DbWork;
using AVLabWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AVLabWeb.Controllers
{
    public class HomeController : Controller
    {
        private IDbProvider DbProvider = new DbProvider
            (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Мвидео\Desktop\AVLabWeb\Students.mdb");

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Students = DbProvider.GetStudentsList().AsEnumerable();

            return View();
        }
    }
}