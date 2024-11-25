using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class HistorialDieta
    {
        [Key]
        public int Id { get; set; }
        public int DietaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Peso { get; set; }
        public string? Comentario { get; set; }

        // Relación con Dieta
        public Dieta Dieta { get; set; } = null!;
    }
}
