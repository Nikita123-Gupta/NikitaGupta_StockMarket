using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AccountAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [StringLength(25)]
        public string UserId { get; set; }
        [Required]
        [StringLength(25)]
        public string UserName { get; set; }
        [Required]
        [StringLength(25)]
        public string Password { get; set; }
        [StringLength(25)]
        public string Email { get; set; }
        [StringLength(25)]
        public string Mobile { get; set; }
        [StringLength(25)]
        public string Confirmed { get; set; }
    }
}
