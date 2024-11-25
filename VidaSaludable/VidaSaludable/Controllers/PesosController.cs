using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VidaSaludable.Models;

namespace VidaSaludable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PesosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Pesos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peso>>> GetPeso()
        {
            return await _context.Peso.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Pesos/Usuario/{usuarioId}
        [HttpGet("Usuario/{usuarioId}")]
        public async Task<ActionResult<Peso>> GetPesoPorUsuario(int usuarioId)
        {
            var peso = await _context.Peso
                .FirstOrDefaultAsync(p => p.UsuarioId == usuarioId);

            if (peso == null)
            {
                return NotFound();
            }

            return Ok(peso);
        }

        // PUT: api/Pesos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeso(int id, Peso peso)
        {
            if (id != peso.Id)
            {
                return BadRequest();
            }

            // Recalcular IMC y resultado al actualizar
            CalcularIMC(peso);

            peso.Usuario = null;

            _context.Entry(peso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PesoExists(id))
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

        // POST: api/Pesos
        [HttpPost]
        public async Task<ActionResult<Peso>> PostPeso(Peso peso)
        {
            // Calcular IMC y resultado antes de guardar
            CalcularIMC(peso);

            peso.Usuario = null;

            _context.Peso.Add(peso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeso", new { id = peso.Id }, peso);
        }

        // DELETE: api/Pesos/Eliminar/5
        [HttpDelete("Eliminar/{id}")]
        public async Task<IActionResult> DeletePeso(int id)
        {
            var peso = await _context.Peso.FindAsync(id);
            if (peso == null)
            {
                return NotFound();
            }

            _context.Peso.Remove(peso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PesoExists(int id)
        {
            return _context.Peso.Any(e => e.Id == id);
        }

        /// <summary>
        /// Calcula el IMC, el resultado, y agrega una recomendación en base al peso.
        /// </summary>
        /// <param name="peso">Objeto Peso</param>
        private void CalcularIMC(Peso peso)
        {
            if (peso.PesoKg <= 0 || peso.Usuario == null || peso.Usuario.Estatura <= 0)
            {
                throw new ArgumentException("Datos insuficientes para calcular IMC.");
            }

            // Calcular IMC
            decimal alturaEnMetros = peso.Usuario.Estatura / 100; // Asume que la altura viene en centímetros
            peso.IMC = Math.Round(peso.PesoKg / (alturaEnMetros * alturaEnMetros), 2);

            // Determinar resultado según IMC
            if (peso.IMC < 18.5m)
            {
                peso.Resultado = "Bajo peso";
                peso.Recomendacion = "Considera aumentar tu ingesta calórica con alimentos saludables.";
            }
            else if (peso.IMC >= 18.5m && peso.IMC <= 24.9m)
            {
                peso.Resultado = "Peso saludable";
                peso.Recomendacion = "Mantén tu estilo de vida actual y continúa cuidando tu alimentación.";
            }
            else if (peso.IMC >= 25m && peso.IMC <= 29.9m)
            {
                peso.Resultado = "Sobrepeso";
                peso.Recomendacion = "Reduce el consumo de alimentos altos en grasas y azúcares.";
            }
            else
            {
                peso.Resultado = "Obesidad";
                peso.Recomendacion = "Consulta a un especialista en nutrición para un plan alimenticio adecuado.";
            }
        }
    }
}
