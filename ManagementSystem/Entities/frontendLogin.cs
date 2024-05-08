using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Entities
{
    public class frontendLogin
    {
        [Required]
        [MaxLength(50)]
        [Key]
        public string user_name { get; set; }
        [Required]
        [MaxLength(50)]
        public string pass_word { get; set; }
    }
}
