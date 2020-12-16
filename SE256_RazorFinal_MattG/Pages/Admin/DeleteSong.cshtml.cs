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
    public class DeleteSongModel : PageModel
    {
        SongDataAccessLayer factory;
        public SongModel sSong { get; set; }

        private readonly IConfiguration _configuration;

        public DeleteSongModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new SongDataAccessLayer(_configuration);
        }
        public ActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            sSong = factory.GetOneRecord(id);

            if(sSong == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            factory.DeleteTicket(id);

            return RedirectToPage("/Admin/ControlPanel");
        }
    }
}
