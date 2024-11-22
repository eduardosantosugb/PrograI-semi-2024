using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class usuarioLogin
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Contra { get; set; }
    }
}