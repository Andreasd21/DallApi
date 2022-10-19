using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DallApi.Data;
using DallApi.Models;

namespace DallApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPaintingsController : ControllerBase
    {
        private readonly DataContext _context;

        public UserPaintingsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/UserPaintings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserPainting>>> GetUserPaintings()
        {
            return await _context.UserPaintings.ToListAsync();
        }

        // GET: api/UserPaintings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserPainting>> GetUserPainting(int id)
        {
            var userPainting = await _context.UserPaintings.FindAsync(id);

            if (userPainting == null)
            {
                return NotFound();
            }

            return userPainting;
        }

        // PUT: api/UserPaintings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPainting(int id, UserPainting userPainting)
        {
            if (id != userPainting.Id)
            {
                return BadRequest();
            }

            _context.Entry(userPainting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPaintingExists(id))
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

        // POST: api/UserPaintings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserPainting>> PostUserPainting(UserPainting userPainting)
        {
            _context.UserPaintings.Add(userPainting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserPainting", new { id = userPainting.Id }, userPainting);
        }

        // DELETE: api/UserPaintings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserPainting(int id)
        {
            var userPainting = await _context.UserPaintings.FindAsync(id);
            if (userPainting == null)
            {
                return NotFound();
            }

            _context.UserPaintings.Remove(userPainting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserPaintingExists(int id)
        {
            return _context.UserPaintings.Any(e => e.Id == id);
        }
    }
}
