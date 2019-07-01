using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreSentencesController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public PreSentencesController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/PreSentences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreSentence>>> GetPreSentences()
        {
            return await _context.PreSentences.ToListAsync();
        }

        // GET: api/PreSentences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PreSentence>> GetPreSentence(int id)
        {
            var preSentence = await _context.PreSentences.FindAsync(id);

            if (preSentence == null)
            {
                return NotFound();
            }

            return preSentence;
        }

        // PUT: api/PreSentences/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreSentence(int id, PreSentence preSentence)
        {
            if (id != preSentence.PSid)
            {
                return BadRequest();
            }

            _context.Entry(preSentence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreSentenceExists(id))
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

        // POST: api/PreSentences
        [HttpPost]
        public async Task<ActionResult<PreSentence>> PostPreSentence(PreSentence preSentence)
        {

            _context.PreSentences.Add(preSentence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPreSentence", new { id = preSentence.PSid }, preSentence);
        }

        // DELETE: api/PreSentences/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PreSentence>> DeletePreSentence(int id)
        {
            var preSentence = await _context.PreSentences.FindAsync(id);
            if (preSentence == null)
            {
                return NotFound();
            }

            _context.PreSentences.Remove(preSentence);
            await _context.SaveChangesAsync();

            return preSentence;
        }

        private bool PreSentenceExists(int id)
        {
            return _context.PreSentences.Any(e => e.PSid == id);
        }
    }
}
