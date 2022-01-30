using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBanco.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Listar();
        T Obter(int id);
        void Adicionar(T entity);
        void Deletar(T entity);
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> DataSet;
        protected ControleDeBancoContext DbContext;
        public Repository(ControleDeBancoContext dbContext)
        {
            DataSet = dbContext.Set<T>();
            DbContext = dbContext;
        }
        public void Adicionar(T entity)
        {
            if (entity is null)
                ArgumentNullException.ThrowIfNull(entity);
            DataSet.Add(entity);
        }

        public void Deletar(T entity)
        {
            if (entity is null)
                ArgumentNullException.ThrowIfNull(entity);
            DataSet.Remove(entity);
        }

        public IEnumerable<T> Listar()
        {
            return DataSet;
        }

        public T Obter(int id)
        {
            return DataSet.Find(id);
        }
    }
}
