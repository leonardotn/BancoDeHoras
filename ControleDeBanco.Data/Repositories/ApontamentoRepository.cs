using ControleDeBanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBanco.Data.Repositories
{
    public interface IApontamentoRepository : IRepository<Apontamento>
    {

    }

    public class ApontamentoRepository : Repository<Apontamento>, IApontamentoRepository
    {
        public ApontamentoRepository(ControleDeBancoContext dbContext) : base(dbContext)
        {
        }
    }
}
