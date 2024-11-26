using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VidaSaludable.Models;

namespace VidaSaludable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public DietasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Dietas/Usuario/{usuarioId}
        [HttpGet("Usuario/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Dieta>>> GetDietasByUsuarioId(int usuarioId)
        {
            var dietas = await _context.Dieta
                                       .Where(d => d.UsuarioId == usuarioId)
                                       .ToListAsync();

            if (dietas == null || !dietas.Any())
            {
                return NotFound(); // Si no se encuentran dietas para el usuario
            }

            return dietas;
        }

        // GET: api/Dietas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Dieta>> GetDieta(int id)
        {
            var dieta = await _context.Dieta.FirstOrDefaultAsync(d => d.Id == id);

            if (dieta == null)
            {
                return NotFound();
            }

            return dieta;
        }

        // PUT: api/Dietas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDieta(int id, Dieta dieta)
        {
            if (id != dieta.Id)
            {
                return BadRequest();
            }

            _context.Entry(dieta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DietaExists(id))
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

        // POST: api/Dietas
        [HttpPost]
        public async Task<ActionResult<Dieta>> PostDieta(Dieta dieta)
        {
            _context.Dieta.Add(dieta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDieta", new { id = dieta.Id }, dieta);
        }

        // DELETE: api/Dietas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDieta(int id)
        {
            // Obtener la dieta por su ID
            var dieta = await _context.Dieta.FindAsync(id);
            if (dieta == null)
            {
                return NotFound("Dieta no encontrada.");
            }

            // Obtener los historiales asociados a esta dieta
            var historiales = await _context.HistorialDieta.Where(h => h.DietaId == id).ToListAsync();
            if (historiales != null && historiales.Any())
            {
                // Eliminar los historiales asociados
                _context.HistorialDieta.RemoveRange(historiales);
            }

            // Eliminar la dieta
            _context.Dieta.Remove(dieta);

            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DietaExists(int id)
        {
            return _context.Dieta.Any(e => e.Id == id);
        }
    }
}
