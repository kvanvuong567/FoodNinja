using System;
using System.ComponentModel.DataAnnotations;

namespace SHOP_FOOD.Model
{
    public class Signup
    {
        public int SignupID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime SignupDate { get; set; } = DateTime.Now;
    }
}
