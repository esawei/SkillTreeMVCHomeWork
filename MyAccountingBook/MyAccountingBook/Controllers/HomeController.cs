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

        [HttpPost]
        public ActionResult Index(ViewModels.Home.AccountingViewModel pageData)
        {
            if (!ModelState.IsValid)
            {
                return View(pageData);
            }

            var item = new Models.AccountBook() {
                Id = Guid.NewGuid(),
                Category = (int)pageData.Category,
                Date = pageData.Date,
                Amount = pageData.Money,
                Remark = pageData.Description
            };

            this.db.AccountBook.Add(item);
            this.db.SaveChanges();

            return View();
        }

        [ChildActionOnly]
        public ActionResult AccountingList()
        {
            var list = this.db.AccountBook.Select(x=>new ViewModels.Home.AccountingViewModel {
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