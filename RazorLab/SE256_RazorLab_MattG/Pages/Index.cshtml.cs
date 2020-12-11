using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_RazorLab_MattG.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public String FName { get; set; }
        public void OnGet()
        {
            //If URL doesn't specify a name
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "User"; //Create default name
            }
        }
    }
}
