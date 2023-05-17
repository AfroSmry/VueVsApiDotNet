using System;
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
    public class WorkersController : ControllerBase
    {
        private readonly DataContext _context;

        public WorkersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Workers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Worker>>> GetMasters()
        {
          if (_context.Masters == null)
          {
              return NotFound();
          }
            return await _context.Masters.ToListAsync();
        }

        // GET: api/Workers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Worker>> GetWorker(int id)
        {
          if (_context.Masters == null)
          {
              return NotFound();
          }
            var worker = await _context.Masters.FindAsync(id);

            if (worker == null)
            {
                return NotFound();
            }

            return worker;
        }

        // PUT: api/Workers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorker(int id, Worker worker)
        {
            if (id != worker.id)
            {
                return BadRequest();
            }

            _context.Entry(worker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkerExists(id))
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

        // POST: api/Workers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Worker>> PostWorker(Worker worker)
        {
          if (_context.Masters == null)
          {
              return Problem("Entity set 'DataContext.Masters'  is null.");
          }
            _context.Masters.Add(worker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorker", new { id = worker.id }, worker);
        }

        // DELETE: api/Workers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorker(int id)
        {
            if (_context.Masters == null)
            {
                return NotFound();
            }
            var worker = await _context.Masters.FindAsync(id);
            if (worker == null)
            {
                return NotFound();
            }

            _context.Masters.Remove(worker);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkerExists(int id)
        {
            return (_context.Masters?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
