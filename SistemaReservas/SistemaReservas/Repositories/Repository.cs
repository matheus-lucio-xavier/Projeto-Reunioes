using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaReservas.Contexts;

namespace SistemaReservas.Repositories
{
    public class Repository
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IQueryable<T> Consultar<T>() where T : class
        {
            return _context.Set<T>().AsQueryable(); 
        }

        public T? ConsultarPorId<T>(long id) where T : class
        {
            return _context.Set<T>().Find(id);
        }

        public bool Cadastrar<T>(T model) where T : class
        {
            _context.Set<T>().Add(model);
            _context.SaveChanges();
            return true;
        }

        public bool Editar<T>(T model) where T : class
        {
            _context.Set<T>().Update(model);
            _context.SaveChanges();
            return true;
        }

        public bool Excluir<T>(T model) where T : class
        {
            _context.Set<T>().Remove(model);
            _context.SaveChanges();
            return true;
        }
    }
}