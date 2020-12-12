using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_RazorLab_MattG.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorLab_MattG.Pages
{
    public class AddMonitorModel : PageModel
    {
        [BindProperty]
        public MonitorModel mMonitor { get; set; }

        private readonly IConfiguration _configuration;

        public AddMonitorModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
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
                if (mMonitor is null == false)
                {
                    MonitorDataAccessLayer factory = new MonitorDataAccessLayer(_configuration);
                    factory.Create(mMonitor);
                }
                temp = Page();
            }
            return temp;
        }

    }
}
