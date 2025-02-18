using System.ComponentModel.DataAnnotations;

namespace SHOP_FOOD.Model
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string ImageURL { get; set; }
    }
}
