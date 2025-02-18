using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SHOP_FOOD.Model
{
    public class Order
    {
        public int OrderID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
