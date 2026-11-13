using SistemaReservas.Contexts;
using SistemaReservas.Enums;
using SistemaReservas.Models;
using SistemaReservas.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Services
{
    public class ReservaService
    {
        private readonly Repository _repository;

        public ReservaService()
        {
            _repository = new Repository(new AppDbContext());
        }

        public ReservaService(Repository repository)
        {
            _repository = repository;
        }

        public List<ReservaModel> Consultar(int page = 0, int pageSize = 10)
        {
            var resultado = page != 0 ?
                _repository.Consultar<ReservaModel>()
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .OrderBy(r => r.Inicio) :
                _repository.Consultar<ReservaModel>()
                .OrderBy(r => r.Inicio);

            return resultado.ToList();
        }

        public List<ReservaModel> Consultar(string pesquisa, int page = 0, int pageSize = 10)
        {
            var resultado = page != 0 ?
                _repository.Consultar<ReservaModel>()
                .Where(r => r.Nome.Contains(pesquisa))
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .OrderBy(r => r.Inicio) :
                _repository.Consultar<ReservaModel>()
                .Where(r => r.Nome.Contains(pesquisa))
                .OrderBy(r => r.Inicio);

            return resultado.ToList();
        }

        public ReservaModel? ConsultarPorId(int id)
        {
            var reserva = _repository.ConsultarPorId<ReservaModel>(id);
            if (reserva == null)
            {
                return null;
            }

            return reserva;
        }

        public bool Criar(ReservaModel reserva, out List<ValidationResult> erros)
        {
            if (!Validar(reserva, out erros))
            {
                return false;
            }

            return _repository.Cadastrar(reserva);
        }

        public bool Editar(ReservaModel reserva, out List<ValidationResult> erros)
        {
            if (!Validar(reserva, out erros))
            {
                return false;
            }

            return _repository.Editar(reserva);
        }

        public bool Deletar(ReservaModel reserva)
        {
            return _repository.Excluir(reserva);
        }

        private bool VerificarColisao(ReservaModel reserva)
        {
            return _repository.Consultar<ReservaModel>().Any(r =>
                r.Id != reserva.Id &&
                r.SalaId == reserva.SalaId &&
                r.Inicio < reserva.Fim &&
                r.Fim > reserva.Inicio
            );
        }

        public bool Validar(ReservaModel reserva, out List<ValidationResult> erros)
        {
            var context = new ValidationContext(reserva);
            erros = new List<ValidationResult>();

            Validator.TryValidateObject(reserva, context, erros, true);

            if (VerificarColisao(reserva))
            {
                erros.Add(new ValidationResult(
                    "Já existe uma reserva para essa sala nesse horário."
                ));
            }

            return erros.Count == 0;
        }

        
    }
}