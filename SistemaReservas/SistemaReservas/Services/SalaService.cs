using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaReservas.Models;
using SistemaReservas.Repositories;

namespace SistemaReservas.Services
{
    public class SalaService
    {
        private readonly Repository _repository;

        public SalaService(Repository repository)
        {
            _repository = repository;
        }

        public List<SalaModel> Consultar()
        {
            var resultado = _repository.Consultar<SalaModel>()
                .OrderBy(x => x.Andar);

            return resultado.ToList();
        }
        public List<SalaModel> Consultar(string pesquisa)
        {
            var resultado = _repository.Consultar<SalaModel>()
                .Where((sala) => sala.Nome.Contains(pesquisa))
                .OrderBy(x => x.Andar);

            return resultado.ToList();
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