using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SistemaReservas.Enums;

namespace SistemaReservas.Models
{
    public class ReservaModel : IValidatableObject
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Nome { get; set; } = String.Empty;
        [Required]
        public DateTime Inicio { get; set; }
        [Required]
        public DateTime Fim { get; set; }
        [Required]
        public ReservaStatusEnum Status { get; set; }
        [Required]
        public long SalaId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Fim <= Inicio)
            {
                yield return new ValidationResult(
                    "O horário final deve ser posterior ao horário inicial.",
                    new[] { nameof(Fim), nameof(Inicio) }
                );
            }

            if (Inicio.TimeOfDay < new TimeSpan(8, 0, 0) || Fim.TimeOfDay > new TimeSpan(19, 0, 0))
            {
                yield return new ValidationResult(
                    "As reservas devem ocorrer entre 08:00 e 19:00.",
                    new[] { nameof(Inicio), nameof(Fim) }
                );
            }
        }
    }
}