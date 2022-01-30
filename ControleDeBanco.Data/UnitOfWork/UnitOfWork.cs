using ControleDeBanco.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBanco.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ControleDeBancoContext Context { get; init; }
        IApontamentoRepository ApontamentoRepository { get; }
        void Commit();
    }

    public class UnitOfWork : IUnitOfWork
    {
        public ControleDeBancoContext Context { get; init; }
        public UnitOfWork(ControleDeBancoContext context)
        {
            Context = context;
        }
        public IApontamentoRepository ApontamentoRepository => new ApontamentoRepository(Context);

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

    }

}
