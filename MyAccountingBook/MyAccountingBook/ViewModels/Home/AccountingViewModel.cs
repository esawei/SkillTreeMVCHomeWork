using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyAccountingBook.ViewModels.Home
{
    public class AccountingViewModel
    {
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Money { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}