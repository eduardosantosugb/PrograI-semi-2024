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
    public class UsuariosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UsuariosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await _context.Usuario.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/Usuarios/register
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] Usuario usuario)
        {
            // Verificación de los datos
            if (string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Contra) || string.IsNullOrEmpty(usuario.Nombre)
                || string.IsNullOrEmpty(usuario.Sexo) || usuario.Edad <= 0 || usuario.Estatura <= 0)
            {
                return BadRequest(new { message = "Todos los campos son requeridos." });
            }

            // Verifica si ya existe un usuario con el mismo correo
            var usuarioExiste = await _context.Usuario.FirstOrDefaultAsync(u => u.Email == usuario.Email);
            if (usuarioExiste != null)
            {
                return BadRequest(new { message = "Este correo ya está registrado." });
            }

            // Agrega el nuevo usuario a la base de datos
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Usuario registrado exitosamente." });
        }

        // POST: api/Usuarios/login
        // Esta ruta verifica las credenciales del usuario (correo y contraseña) en la base de datos.
        // Si las credenciales son correctas, el usuario puede iniciar sesión. Si no, se devolverá un error de "Credenciales incorrectas".
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] usuarioLogin usuarioLogin)
        {
            if (string.IsNullOrEmpty(usuarioLogin.Email) || string.IsNullOrEmpty(usuarioLogin.Contra))
            {
                return BadRequest(new { message = "El correo y la contraseña son requeridos." });
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(u => u.Email == usuarioLogin.Email && u.Contra == usuarioLogin.Contra);

            if (usuario == null)
            {
                return Unauthorized(new { message = "Credenciales incorrectas." });
            }

            return Ok(new { message = "Inicio de sesión exitoso.", usuario = usuario });
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }
    }
}
