using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VidaSaludable.Models;

namespace VidaSaludable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public MetasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Metas/Usuario/{usuarioId}
        [HttpGet("Usuario/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Meta>>> GetMetasByUsuarioId(int usuarioId)
        {
            var metas = await _context.Meta
                                       .Where(m => m.UsuarioId == usuarioId)
                                       .ToListAsync();

            if (metas == null || !metas.Any())
            {
                return NotFound(); // Si no se encuentran metas para el usuario
            }

            return metas;
        }

        // GET: api/Metas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Meta>> GetMeta(int id)
        {
            var meta = await _context.Meta.FindAsync(id);

            if (meta == null)
            {
                return NotFound();
            }

            return meta;
        }

        // PUT: api/Metas/5/estado
        [HttpPut("{id}/estado")]
        public async Task<IActionResult> PutMeta(int id, [FromBody] JsonElement request)
        {
            // Verificar que el ID es válido
            var meta = await _context.Meta.FindAsync(id);
            if (meta == null)
            {
                return NotFound();
            }

            // Validar el campo 'estado' en el cuerpo de la solicitud
            if (!request.TryGetProperty("estado", out var estadoProperty) || string.IsNullOrEmpty(estadoProperty.GetString()))
            {
                return BadRequest(new { message = "El campo 'estado' es obligatorio." });
            }

            // Actualizar solo el estado de la meta
            var nuevoEstado = estadoProperty.GetString();
            meta.Estado = nuevoEstado;

            _context.Entry(meta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetaExists(id))
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

        // POST: api/Metas
        [HttpPost]
        public async Task<ActionResult<Meta>> PostMeta(Meta meta)
        {
            _context.Meta.Add(meta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeta", new { id = meta.Id }, meta);
        }

        // DELETE: api/Metas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeta(int id)
        {
            var meta = await _context.Meta.FindAsync(id);
            if (meta == null)
            {
                return NotFound();
            }

            _context.Meta.Remove(meta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MetaExists(int id)
        {
            return _context.Meta.Any(e => e.Id == id);
        }
    }
}
