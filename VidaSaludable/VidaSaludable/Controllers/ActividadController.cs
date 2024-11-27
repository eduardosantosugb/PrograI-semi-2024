using Microsoft.AspNetCore.Mvc;
using VidaSaludable.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Controllers
{
    [ApiController]
    [Route("api/actividades")]
    public class ActividadController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ActividadController(MyDbContext context)
        {
            _context = context;
        }

        // Obtener todas las actividades de un usuario
        [HttpGet("usuario/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Actividad>>> GetActividadesByUsuario(int usuarioId)
        {
            var actividades = await _context.Actividad
                .Where(a => a.UsuarioId == usuarioId)
                .ToListAsync();

            //if (!actividades.Any())
            //{
            //    return NotFound("No se encontraron actividades para este usuario.");
            //}

            return Ok(actividades);
        }

        // Obtener una actividad por su ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Actividad>> GetActividad(int id)
        {
            var actividad = await _context.Actividad.FindAsync(id);

            if (actividad == null)
            {
                return NotFound("Actividad no encontrada.");
            }

            return Ok(actividad);
        }

        // Crear una nueva actividad
        [HttpPost]
        public async Task<ActionResult<Actividad>> CreateActividad([FromBody] Actividad nuevaActividad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Actividad.Add(nuevaActividad);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetActividad), new { id = nuevaActividad.Id }, nuevaActividad);
        }

        // Actualizar una actividad completa
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateActividad(int id, [FromBody] Actividad actividadActualizada)
        {
            var actividad = await _context.Actividad.FindAsync(id);

            if (actividad == null)
            {
                return NotFound("Actividad no encontrada.");
            }

            actividad.Descripcion = actividadActualizada.Descripcion;
            actividad.FechaInicio = actividadActualizada.FechaInicio;
            actividad.Estado = actividadActualizada.Estado;

            _context.Entry(actividad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActividadExists(id))
                {
                    return NotFound("La actividad ya no existe.");
                }
                throw;
            }

            return NoContent();
        }


        // Eliminar una actividad
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActividad(int id)
        {
            var actividad = await _context.Actividad.FindAsync(id);

            if (actividad == null)
            {
                return NotFound("Actividad no encontrada.");
            }

            _context.Actividad.Remove(actividad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar si existe una actividad
        private bool ActividadExists(int id)
        {
            return _context.Actividad.Any(a => a.Id == id);
        }
    }
}
