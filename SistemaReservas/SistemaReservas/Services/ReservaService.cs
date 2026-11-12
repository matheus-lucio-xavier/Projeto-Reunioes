using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SistemaReservas.Enums;
using SistemaReservas.Models;
using SistemaReservas.Repositories;

namespace SistemaReservas.Services
{
    public class ReservaService
    {
        private readonly Repository _repository;

        public ReservaService(Repository repository)
        {
            _repository = repository;
        }

        public List<ReservaModel> Consultar()
        {
            var resultado = _repository.Consultar<ReservaModel>()
                .OrderBy(r => r.Inicio);

            return resultado.ToList();
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