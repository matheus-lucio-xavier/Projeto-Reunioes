using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class Sala
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(80)]
        [RegularExpression("^[a-zA-Z]+$")]
        public string Nome { get; set; } = String.Empty;
        [Required]
        public int Andar { get; set; }
        [Required]
        [Range(1, 100)]
        public int qtdAssentos { get; set; }
    }
}