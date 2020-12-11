using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_RazorLab_MattG.Models
{
    public class MonitorModel
    {
        [Required]
        public int Monitor_ID { get; set; } //primary key

        [Required, StringLength(255)]
        public String Monitor_Name { get; set; } //Model of monitor
        
        [Required]
        public int Monitor_Price { get; set; } //Price of monitor
        
        [Required]
        [StringOptionsValidate(Allowed = new String[] { "TN", "IPS", "VA", "PLS", "AHVA"}, ErrorMessage = "Panel type is invalid, choose between: TN, IPS, VA, PLS, AHVA")]
        public String Monitor_Panel { get; set; } //Type of panel monitor uses
        
        [Required]
        public String Monitor_RefreshRate { get; set; } //Refresh Rate of monitor
        
        [Required]
        public String Monitor_Brand { get; set; } //Brand of monitor
        
        [Required]
        public String Monitor_Size { get; set; } //Size of monitor


    }
}
