using Microsoft.AspNetCore.Mvc;
using VidaSaludable.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public HistorialesController(MyDbContext context)
        {
            _context = context;
        }

        // Obtener el historial de una dieta por ID
        [HttpGet("dieta/{dietaId}")]
        public async Task<IActionResult> GetHistorialByDieta(int dietaId)
        {
            var historial = await _context.HistorialDieta
                .Where(h => h.DietaId == dietaId)
                .OrderBy(h => h.Fecha)
                .ToListAsync();

            if (historial == null || historial.Count == 0)
            {
                return NotFound("No se encontraron registros de historial para esta dieta.");
            }
            return Ok(historial);
        }

        // Obtener un historial por su ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistorialById(int id)
        {
            var historial = await _context.HistorialDieta.FindAsync(id);

            if (historial == null)
            {
                return NotFound("Historial no encontrado.");
            }
            return Ok(historial);
        }

        // Crear un nuevo historial para una dieta
        [HttpPost]
        public async Task<IActionResult> CreateHistorial([FromBody] HistorialDieta historialDieta)
        {
            if (historialDieta == null)
            {
                return BadRequest("El registro de historial no es válido.");
            }

            _context.HistorialDieta.Add(historialDieta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHistorialById), new { id = historialDieta.Id }, historialDieta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHistorial(int id, [FromBody] HistorialDieta updatedHistorial)
        {
            // Validar si existe el historial antes de actualizar.
            var historial = await _context.HistorialDieta.FindAsync(id);
            if (historial == null)
            {
                return NotFound("Historial no encontrado.");
            }

            // Actualizar propiedades del historial existente.
            historial.Peso = updatedHistorial.Peso;
            historial.Comentario = updatedHistorial.Comentario;
            historial.Fecha = updatedHistorial.Fecha;

            // Guardar cambios.
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Verificar si el historial sigue existiendo tras el intento de guardar.
                if (!_context.HistorialDieta.Any(h => h.Id == id))
                {
                    return NotFound("Historial no encontrado después de la actualización.");
                }
                throw; // Relanzar excepción si ocurre un problema diferente.
            }

            return NoContent();
        }

        // Eliminar un historial por ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistorial(int id)
        {
            var historial = await _context.HistorialDieta.FindAsync(id);
            if (historial == null)
            {
                return NotFound("Historial no encontrado.");
            }

            _context.HistorialDieta.Remove(historial);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
