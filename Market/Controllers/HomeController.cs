using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Market.Models;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        WatchContext watchContext = new WatchContext();
        public ActionResult Index()
        {
            //извлекаем данные из таблицы Watches
            IEnumerable<Watch> watches = watchContext.Watches;

            ViewBag.Watches = watches;
            return View();
        }

        [HttpGet]

        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpGet]
        public ActionResult MyView(Purchase purchase)
        {
            purchase.DateTime = GetTodayDate();

            watchContext.Purchases.Add(purchase);

            watchContext.SaveChanges();

            return View();
        }

        public DateTime GetTodayDate()
        {
            return DateTime.Now;
        }

        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult LastPage()
        {
            return View();
        }
    }
}