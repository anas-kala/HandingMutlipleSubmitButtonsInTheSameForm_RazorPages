using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HandingMutlipleSubmitButtonsInTheSameForm_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string Msg { get; set; }

        public void OnGet()
        {

        }

        public void OnPostWork1()
        {
            Msg = "work 1";
        }
        public void OnPostWork2()
        {
            Msg = "work 2";
        }

        public void OnPostWork3()
        {
            Msg = "work 3";
        }
    }
}

