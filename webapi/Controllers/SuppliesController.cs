/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Models;
using webapi.Models.DataContext;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliesController : ControllerBase
    {
        private readonly DataContext _context;

        public SuppliesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Supplies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplies>>> GetSupplies()
        {
          if (_context.Supplies == null)
          {
              return NotFound();
          }
            return await _context.Supplies.ToListAsync();
        }

        // GET: api/Supplies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplies>> GetSupplies(int id)
        {
          if (_context.Supplies == null)
          {
              return NotFound();
          }
            var supplies = await _context.Supplies.FindAsync(id);

            if (supplies == null)
            {
                return NotFound();
            }

            return supplies;
        }

        // PUT: api/Supplies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplies(int id, Supplies supplies)
        {
            if (id != supplies.id)
            {
                return BadRequest();
            }

            _context.Entry(supplies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliesExists(id))
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

        // POST: api/Supplies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Supplies>> PostSupplies(Supplies supplies)
        {
          if (_context.Supplies == null)
          {
              return Problem("Entity set 'DataContext.Supplies'  is null.");
          }
            _context.Supplies.Add(supplies);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplies", new { id = supplies.id }, supplies);
        }

        // DELETE: api/Supplies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplies(int id)
        {
            if (_context.Supplies == null)
            {
                return NotFound();
            }
            var supplies = await _context.Supplies.FindAsync(id);
            if (supplies == null)
            {
                return NotFound();
            }

            _context.Supplies.Remove(supplies);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuppliesExists(int id)
        {
            return (_context.Supplies?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
*/