using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using SE256_RazorFinal_MattG.Models;

using System.Data;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace SE256_RazorFinal_MattG.Models
{
    public class SongAdmin
    {
        [Required]
        public int SongAdmin_ID { get; set; }

        [EmailAddress]
        [Display(Name = "Username")]
        public String SongAdmin_Email { get; set; }

        [Required, StringLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String SongAdmin_PW { get; set; }

        public String Feedback { get; set; }
    }
}
