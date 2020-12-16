using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_RazorFinal_MattG.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorFinal_MattG.Pages.Admin
{
    public class EditSongModel : PageModel
    {
        private readonly IConfiguration _configuration;

        [BindProperty]
        public SongModel sSong { get; set; }
        public SongDataAccessLayer factory;

        public EditSongModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new SongDataAccessLayer(_configuration);
        }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                sSong = factory.GetOneRecord(id);
            }

            if (sSong == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            factory.UpdateTicket(sSong);

            return RedirectToPage("/Admin/ControlPanel");
        }
    }
}
