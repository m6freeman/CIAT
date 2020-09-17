using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace chapterFifteenProjectTwo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Size")]
        public string Size { get; set; }
        [DisplayName("Sizes")]

        public List<SelectListItem> Sizes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Small", Text = "Small" },
            new SelectListItem { Value = "Medium", Text = "Medium" },
            new SelectListItem { Value = "Large", Text = "Large"  },
            new SelectListItem { Value = "X-Large", Text = "X-Large"  },
            new SelectListItem { Value = "XX-Large", Text = "XX-Large"  },
        };

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]

        public string LastName { get; set; }
        [DisplayName("Phone Number")]

        public string PhoneNumber { get; set; }
        [DisplayName("Email Address")]

        public string Email { get; set; }
        public double SalesTax { get; set; }
        public string Total { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            SalesTax = 0.07;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            FirstName = Request.Form[nameof(FirstName)];
            LastName = Request.Form[nameof(LastName)];
            PhoneNumber = Request.Form[nameof(PhoneNumber)];
            Email = Request.Form[nameof(Email)];
            Quantity = int.Parse(Request.Form[nameof(Quantity)]);
            Size = Request.Form[nameof(Size)];
            double subTotal = ((Size == "XX-Large") ? 30 : 26 ) * Quantity;
            Total = string.Format("{0:C}", subTotal + (subTotal * SalesTax));
            ViewData["Result"] = $"Thank you {FirstName} {LastName},\n" +
                                 $"You have reserved {Quantity} {Size} shirt(s).\n" +
                                 $"Your total due upon receipt will be {Total}";
        }
    }

    public class Ex
    {
        public int x { get; set; }

    }

    public class Why : Ex
    {
        public int y { get; set; }

    }

    public class test
    {
        void main()
        {
            Ex X = new Ex();
            Ex Y = new Why();
            Why Y2 = new Why();
            System.Console.WriteLine(X.x);
            System.Console.WriteLine(X.y); //'Ex' does not contain a definition for 'y'
            System.Console.WriteLine(Y.x);
            System.Console.WriteLine(Y.y); //'Ex' does not contain a definition for 'y'
            System.Console.WriteLine(Y2.x);
            System.Console.WriteLine(Y2.y);
        }
    }
}