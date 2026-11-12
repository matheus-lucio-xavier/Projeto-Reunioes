using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaReservas.Dto.Response
{
    public class ResponseSalaDto
    {
        public long Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public int Andar { get; set; }
        public int qtdAssentos { get; set; }
        public double HorasLivres { get; set; }
        public int ReunioesAgendadas { get; set; }
    }
}