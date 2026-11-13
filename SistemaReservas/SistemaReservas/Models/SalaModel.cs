using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SistemaReservas.Enums;

namespace SistemaReservas.Models
{
    public class SalaModel
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Nome { get; set; } = String.Empty;
        [Required]
        public int Andar { get; set; }
        [Required]
        [Range(1, 100)]
        public int qtdAssentos { get; set; }
        public SalaStatusEnum Status { get; set; }
    }
}