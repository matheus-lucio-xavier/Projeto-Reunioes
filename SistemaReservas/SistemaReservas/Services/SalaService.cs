using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaReservas.Contexts;
using SistemaReservas.Dto.Response;
using SistemaReservas.Enums;
using SistemaReservas.Models;
using SistemaReservas.Repositories;

namespace SistemaReservas.Services
{
    public class SalaService
    {
        private readonly Repository _repository;
        public SalaService()
        {
            _repository = new Repository(new AppDbContext());
        }

        public SalaService(Repository repository)
        {
            _repository = repository;
        }

        public List<ResponseSalaDto> Consultar(int page = 0, int pageSize = 10)
        {

            var salas = page != 0 ?
                _repository.Consultar<SalaModel>()
                    .Where(s => s.Status == SalaStatusEnum.ATIVA)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .OrderBy(x => x.Andar) :
                _repository.Consultar<SalaModel>()
                    .Where(s => s.Status == SalaStatusEnum.ATIVA)
                    .OrderBy(x => x.Andar);

            var reservas = _repository.Consultar<ReservaModel>()
                .Where(r => 
                    r.Inicio < DateTime.Today.ToUniversalTime() &&
                    r.Fim > DateTime.Today.AddDays(-7).ToUniversalTime() &&
                    r.Status != ReservaStatusEnum.CANCELADA);

            var resultado = salas.Select(s =>
                new ResponseSalaDto
                {
                    Id = s.Id,
                    Nome = s.Nome,
                    Andar = s.Andar,
                    qtdAssentos = s.qtdAssentos,
                    HorasLivres = Math.Round((7 * 11) - reservas.Where(r => r.SalaId == s.Id).Sum(r => (r.Fim - r.Inicio).TotalMinutes) / 60, 2),
                    ReunioesAgendadas = reservas.Where(r => r.SalaId == s.Id).Count()
                }
            ).ToList();

            return resultado;
        }
        public List<ResponseSalaDto> Consultar(string pesquisa, int page = 0, int pageSize = 10)
        {
            var salas = page != 0 ?
                _repository.Consultar<SalaModel>()
                    .Where(s => s.Nome.Contains(pesquisa) && s.Status == SalaStatusEnum.ATIVA)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .OrderBy(x => x.Andar) :
                _repository.Consultar<SalaModel>()
                    .Where(s => s.Nome.Contains(pesquisa) && s.Status == SalaStatusEnum.ATIVA)
                    .OrderBy(x => x.Andar);


            var reservas = _repository.Consultar<ReservaModel>()
                .Where(r => 
                    r.Inicio < DateTime.Today.ToUniversalTime() &&
                    r.Fim > DateTime.Today.AddDays(-7).ToUniversalTime() &&
                    r.Status != ReservaStatusEnum.CANCELADA);

            var resultado = salas.Select(s =>
                new ResponseSalaDto
                {
                    Id = s.Id,
                    Nome = s.Nome,
                    Andar = s.Andar,
                    qtdAssentos = s.qtdAssentos,
                    HorasLivres = (7 * 11) - reservas.Where(r => r.SalaId == s.Id).Sum(r => (r.Fim - r.Inicio).TotalMinutes) / 60,
                    ReunioesAgendadas = reservas.Where(r => r.SalaId == s.Id).Count()
                }
            ).ToList();

            return resultado;
        }

        public SalaModel? ConsultarPorId(long id)
        {
            var resultado = _repository.ConsultarPorId<SalaModel>(id);

            if (resultado == null)
            {
                return null;
            }

            return resultado;
        }

        public bool Criar(SalaModel sala, out List<ValidationResult> erros)
        {
            if (!Validar(sala, out erros))
            {
                return false;
            }

            return _repository.Cadastrar(sala);
        }

        public bool Editar(SalaModel sala, out List<ValidationResult> erros)
        {
            if (!Validar(sala, out erros))
            {
                return false;
            }

            return _repository.Editar(sala);
        }

        public bool Deletar(SalaModel sala)
        {
            if (sala.Status == SalaStatusEnum.ATIVA)
            {
                foreach(var r in _repository.Consultar<ReservaModel>().Where(r => r.SalaId == sala.Id && r.Status != ReservaStatusEnum.CANCELADA))
                {
                    r.Status = ReservaStatusEnum.CANCELADA;
                    return _repository.Editar(r);
                }

                sala.Status = SalaStatusEnum.INATIVA;
                return _repository.Editar(sala);
            }
            return _repository.Excluir(sala);
        }

        public bool Validar(SalaModel sala, out List<ValidationResult> erros)
        {
            var context = new ValidationContext(sala);
            erros = new List<ValidationResult>();
            return Validator.TryValidateObject(sala, context, erros, true);
        }
    }
}