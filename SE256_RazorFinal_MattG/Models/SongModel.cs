using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_RazorFinal_MattG.Models
{
    public class SongModel
    {
        [Required]
        public int Song_ID { get; set; } //primary key

        [Required, StringLength(255)]
        public String Song_Title { get; set; } //Title of song

        [Required]
        public String Song_Artist { get; set; } //Artist of song

        [Required]
        [RegularExpression(@"^[0-9]+\:[0-5]+\d$", ErrorMessage = "Please enter a time in the MM:SS format e.g 5:00, 63:24, 3:59")]
        public String Song_PlayTime { get; set; } //Length of song

        [Required]
        [RegularExpression(@"^[1-5]\.[05]$", ErrorMessage = "Please a 1-5 rating, ending in '.0' or '.5' e.g 3.0, 4.5, 5.0")]
        public Decimal Song_Rating { get; set; } //Song rating

        [Required]
        [Display(Name = "Song Release Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future dates not allowed")]
        public DateTime Song_Date { get; set; } //Release date of song

        [Required]
        public Boolean Song_Owned { get; set; } //Whether the song is owned or not
        
        [Required]
        [EmailAddress]
        public String Artist_Email { get; set; } //Artist's email

        [Required]
        public String Artist_Website { get; set; } //Artist's website

        
        public String Feedback { get; set; }
    }
}
