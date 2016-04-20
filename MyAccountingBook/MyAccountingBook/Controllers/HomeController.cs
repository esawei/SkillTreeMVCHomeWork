using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAccountingBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult AccountingList()
        {
            var items = new List<ViewModels.Home.AccountingViewModel>() {
                new ViewModels.Home.AccountingViewModel() { Category="支出", Date=DateTime.Parse("2016-01-01"), Money=300, Description="天龍便當" },
                new ViewModels.Home.AccountingViewModel() { Category="收入", Date=DateTime.Parse("2016-01-01"), Money=300, Description="天龍便當1" },
                new ViewModels.Home.AccountingViewModel() { Category="支出", Date=DateTime.Parse("2016-01-01"), Money=300, Description="天龍便當2" }
            };
            return View(items);
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