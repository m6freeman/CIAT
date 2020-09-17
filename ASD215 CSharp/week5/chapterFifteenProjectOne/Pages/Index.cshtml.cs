using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace chapterFifteenProjectOne.Pages
{
    public class IndexModel : PageModel
    {
        [DisplayName("Testing Date")]
        public DateTime Today { get; set; }
        public DateTime Date { get; set; }
        public string ShortDate { get; set; }

        public IndexModel()
        {
            Today = DateTime.Today;
        }

        public void OnGet()
        {
            Date = DateTime.Today;
        }

        public void OnPost()
        {
            DateTime.TryParse(Request.Form[nameof(Date)], out DateTime date);
            ShortDate = date.ToShortDateString();
            ViewData["Response"] = (date > DateTime.Today)
                ? $"You are scheduled to take your test on {ShortDate}"
                : "Please enter a date in the future.";
        }
    }
}
