using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public string Estado { get; set; } = null!; // Activa, Completada, Cancelada

        // Relación con Usuario
        public Usuario Usuario { get; set; } = null!;

        // Relación con HistorialActividades
        public ICollection<HistorialActividades> HistorialActividades { get; set; } = new List<HistorialActividades>();
    }
}
