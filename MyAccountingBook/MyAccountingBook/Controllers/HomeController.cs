using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace MyAccountingBook.Controllers
{
    public class HomeController : Controller
    {
        Models.SkillTreeHomeworkEntities db = new Models.SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult AccountingList()
        {
            var list = db.AccountBook.Select(x=>new ViewModels.Home.AccountingViewModel {
                Category = (ViewModels.Home.AcctountingCategory)x.Category,
                Date = x.Date,
                Money = x.Amount,
                Description = x.Remark
            }).OrderByDescending(x=>x.Date)
            .Take(20);
            return View(list);
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