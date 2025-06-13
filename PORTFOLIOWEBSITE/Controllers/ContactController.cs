using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PortfolioWebsite.Data;      // change to your actual namespace
using PortfolioWebsite.Models;   // change to your actual namespace

namespace PortfolioWebsite.Controllers  // change to your root namespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: /api/contact
        [HttpPost]
        public async Task<IActionResult> Submit(ContactMessage message)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _context.ContactMessages.Add(message);
            await _context.SaveChangesAsync();

            // Optionally send a confirmation e-mail here …

            return Ok(new { status = "Message received successfully!" });
        }
    }
}