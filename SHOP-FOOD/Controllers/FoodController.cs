using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SHOP_FOOD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private static readonly List<dynamic> Foods = new List<dynamic>
    {
        new { Id = 1, Name = "Pizza", Price = 12.99 },
        new { Id = 2, Name = "Burger", Price = 8.99 },
        new { Id = 3, Name = "Sushi", Price = 15.99 }
    };

        [HttpGet]
        public IActionResult GetAllFoods()
        {
            return Ok(Foods);
        }

        [HttpGet("{id}")]
        public IActionResult GetFoodById(int id)
        {
            var food = Foods.FirstOrDefault(f => f.Id == id);
            return food != null ? Ok(food) : NotFound();
        }
    }

}
