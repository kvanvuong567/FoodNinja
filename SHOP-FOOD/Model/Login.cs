using System;

namespace SHOP_FOOD.Model
{
    public class Login
    {
        public int LoginID { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public DateTime? LastLoginDate { get; set; }
    }
}
