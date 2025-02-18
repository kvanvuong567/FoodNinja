using System;
using System.ComponentModel.DataAnnotations;

namespace SHOP_FOOD.Model
{
    public class Feedback
    {
        public int FeedbackID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }

        public DateTime FeedbackDate { get; set; } = DateTime.Now;
    }
}
