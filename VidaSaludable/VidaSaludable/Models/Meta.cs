using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class Meta
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string? Descripcion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaMeta { get; set; }
        public string? Estado { get; set; } = "Pendiente"; // Pendiente o Completada

        // Relación con Usuario
        [ValidateNever]
        public Usuario Usuario { get; set; } = null!;
    }
}
