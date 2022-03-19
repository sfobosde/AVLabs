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
        /// <summary>
        /// Создаем интерфейс для получения данных из бд. Все остальное скрыто.
        /// </summary>
        private IDbProvider DbProvider = new DbProvider
            (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Мвидео\Desktop\AVLabWeb\Students.mdb");

        /// <summary>
        /// Главная страница. Выводит список студентов.
        /// </summary>
        /// <returns> Страница со списком студентов. </returns>
        public ActionResult Index()
        {
            ViewBag.Students = DbProvider.GetStudentsList().AsEnumerable();

            return View();
        }

        /// <summary>
        /// Получение данных о сданых экзаменах студента по id.
        /// </summary>
        /// <param name="StudentId"> id студента. </param>
        /// <returns> Страница с данным о экзаменах студента. </returns>
        [HttpGet]
        public ActionResult Exams(int id)
		{
            var examsList = DbProvider.GetStudentExams(id);
            ViewBag.Exams = examsList.AsEnumerable();
            ViewBag.ExamsCount = examsList.Count();
            return View();
		}
    }
}