using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; } = null!; // Masculino o Femenino
        public int Edad { get; set; }
        public decimal Estatura { get; set; } // En cm
        public string Contra { get; set; } = null!;

        // Relación con otras entidades
        public ICollection<Peso>? Pesos { get; set; } = new List<Peso>();
        public ICollection<Dieta>? Dietas { get; set; } = new List<Dieta>();
        public ICollection<Meta>? Metas { get; set; } = new List<Meta>();
        public ICollection<Actividad>? Actividades { get; set; } = new List<Actividad>();
    }
}