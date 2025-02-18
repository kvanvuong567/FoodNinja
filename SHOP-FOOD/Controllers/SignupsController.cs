using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SHOP_FOOD.Data;
using SHOP_FOOD.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_FOOD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SignupsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Signup>>> GetSignups()
        {
            return await _context.Signups.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Signup>> GetSignup(int id)
        {
            var signup = await _context.Signups.FindAsync(id);

            if (signup == null)
            {
                return NotFound();
            }

            return signup;
        }

        [HttpPost]
        public async Task<ActionResult<Signup>> PostSignup(Signup signup)
        {
            _context.Signups.Add(signup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSignup", new { id = signup.SignupID }, signup);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSignup(int id, Signup signup)
        {
            if (id != signup.SignupID)
            {
                return BadRequest();
            }

            _context.Entry(signup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SignupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSignup(int id)
        {
            var signup = await _context.Signups.FindAsync(id);
            if (signup == null)
            {
                return NotFound();
            }

            _context.Signups.Remove(signup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SignupExists(int id)
        {
            return _context.Signups.Any(e => e.SignupID == id);
        }
    }
}
