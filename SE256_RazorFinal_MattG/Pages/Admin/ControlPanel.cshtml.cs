using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using SE256_RazorFinal_MattG.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorFinal_MattG.Pages.Admin
{
    public class ControlPanelModel : PageModel
    {
        private readonly IConfiguration _configuration;

        SongDataAccessLayer factory;
        public List<SongModel> sngs { get; set; }

        public ControlPanelModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new SongDataAccessLayer(_configuration);
        }
        public IActionResult OnGet()
        {
            IActionResult temp;

            if (HttpContext.Session.GetString("SongAdmin_Email") is null)
            {
                temp = RedirectToPage("/Admin/Index");
            }
            else
            {
                sngs = factory.GetActiveRecords().ToList();
                temp = Page();
            }

            return temp;
        }
    }
}
