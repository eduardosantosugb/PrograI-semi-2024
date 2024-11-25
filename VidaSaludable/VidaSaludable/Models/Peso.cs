using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class Peso
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal PesoKg { get; set; }
        public decimal IMC { get; set; }
        public string? Resultado { get; set; } = null!; // Bajo peso, Peso saludable, Sobrepeso, Obesidad
        public string? Recomendacion { get; set; }

        // Relación con Usuario
        [ValidateNever]
        public Usuario? Usuario { get; set; }
    }

}
