using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyAccountingBook.ViewModels.Home
{
    public enum AcctountingCategory { 收入, 支出 };

    public class AccountingViewModel
    {
        [Display(Name = "類別")]
        public AcctountingCategory Category { get; set; }

        [Display(Name ="金額")]
        [DisplayFormat(DataFormatString = "{0:##,##}")]
        public int Money { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}")]
        public DateTime Date { get; set; }

        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}