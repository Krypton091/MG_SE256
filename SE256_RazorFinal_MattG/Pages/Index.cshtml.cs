using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SE256_RazorFinal_MattG.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_RazorFinal_MattG.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public String FName { get; set; }

        private readonly IConfiguration _configuration;

        SongDataAccessLayer factory;
        public List<SongModel> sngs { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new SongDataAccessLayer(_configuration);
        }
        public void OnGet()
        {
            //If URL doesn't specify a name
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "User"; //Create default name
            }

            sngs = factory.GetActiveRecords().ToList();
        }

       
    }
}
