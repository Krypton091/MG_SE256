using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_RazorLab_MattG.Models;

namespace SE256_RazorLab_MattG.Pages
{
    public class AddMonitorModel : PageModel
    {
        [BindProperty]
        public MonitorModel mMonitor { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            IActionResult temp;

            if (ModelState.IsValid == false) //If there are errors, go to this page
            {
                temp = Page();
            }
            else
            {
                temp = Page();
            }
            return temp;
        }

    }
}
