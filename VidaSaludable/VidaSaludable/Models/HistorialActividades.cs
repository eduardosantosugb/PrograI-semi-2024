using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class HistorialActividades
    {
        [Key]
        public int Id { get; set; }
        public int ActividadId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string? Progreso { get; set; } // Detalles del progreso (duración, intensidad, etc.)
        public string? Comentario { get; set; }

        // Relación con Actividad
        public Actividad Actividad { get; set; } = null!;
    }
}
