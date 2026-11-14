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
        [Required(ErrorMessage = "O nome da sala é obrigatório.")]
        public string Nome { get; set; } = String.Empty;
        [Required(ErrorMessage = "O andar é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O andar deve ser um valor positivo maior que zero.")]
        public int Andar { get; set; }
        [Required(ErrorMessage = "A quantidade de assentos é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade de assentos deve ser um valor positivo maior que zero.")]
        public int qtdAssentos { get; set; }
        public SalaStatusEnum Status { get; set; }
    }
}