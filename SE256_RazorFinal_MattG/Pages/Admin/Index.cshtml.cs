using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_RazorFinal_MattG.Models;

using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SE256_RazorFinal_MattG.Pages.Admin
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public SongAdmin sAdmin { get; set; }
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            HttpContext.Session.SetInt32("test", 5);
        }

        public IActionResult OnPost()
        {
            IActionResult temp;
            List<SongAdmin> lstSongAdmin = new List<SongAdmin>();

            if (ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                if (sAdmin != null)
                {
                    SongAdminDataAccessLayer factory = new SongAdminDataAccessLayer(_configuration);

                    lstSongAdmin = factory.GetAdminLogin(sAdmin).ToList();

                    if (lstSongAdmin.Count > 0)
                    {
                        HttpContext.Session.SetInt32("SongAdmin_ID", lstSongAdmin[0].SongAdmin_ID);
                        HttpContext.Session.SetString("SongAdmin_Email", lstSongAdmin[0].SongAdmin_Email);
                        temp = Redirect("/Admin/ControlPanel");
                    }
                    else
                    {
                        sAdmin.Feedback = "Login Failed";
                        temp = Page();
                    }
                }
                else
                {
                    temp = Page();
                }
            }

            return temp;
        }
    }
}
