using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class Dieta
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string TipoDieta { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public string Estado { get; set; } = null!; // Activa, Finalizada, Cancelada
        public decimal KilosIniciales { get; set; }
        public decimal? KilosFinales { get; set; } // Puede ser nulo si no termina

        // Relación con Usuario
        public Usuario Usuario { get; set; } = null!;

        // Relación con HistorialDieta
        public ICollection<HistorialDieta> HistorialDietas { get; set; } = new List<HistorialDieta>();
    }
}
