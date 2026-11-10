using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class ReservaModel
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public DateTime Inicio { get; set; }
        [Required]
        public DateTime Fim { get; set; }
        [Required]
        public long SalaId { get; set; }
    }
}