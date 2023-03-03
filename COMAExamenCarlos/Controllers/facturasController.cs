using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMAExamenCarlos.Modal;

namespace COMAExamenCarlos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class facturasController : ControllerBase
    {
        private readonly APIDbContext _context;

        public facturasController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/facturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<facturas>>> GetFacturas()
        {
            return await _context.Facturas.ToListAsync();
        }

        // GET: api/facturas
        [HttpGet("{id}")]
        public async Task<ActionResult<facturas>> Getfacturas(int id)
        {
            var facturas = await _context.Facturas.FindAsync(id);

            if (facturas == null)
            {
                return NotFound();
            }

            return facturas;
        }

        // PUT: api/facturas
        [HttpPut("{id}")]
        public async Task<IActionResult> Putfacturas(int id, facturas facturas)
        {
            if (id != facturas.Id)
            {
                return BadRequest();
            }

            _context.Entry(facturas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!facturasExists(id))
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

        // POST: api/facturas
        [HttpPost]
        public async Task<ActionResult<facturas>> Postfacturas(facturas facturas)
        {
            _context.Facturas.Add(facturas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getfacturas", new { id = facturas.Id }, facturas);
        }

        // DELETE: api/facturas
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletefacturas(int id)
        {
            var facturas = await _context.Facturas.FindAsync(id);
            if (facturas == null)
            {
                return NotFound();
            }

            _context.Facturas.Remove(facturas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool facturasExists(int id)
        {
            return _context.Facturas.Any(e => e.Id == id);
        }
    }
}
