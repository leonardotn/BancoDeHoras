using ControleDeBanco.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBanco.Data.Configuration
{
    public class ApontamentoConfiguration : IEntityTypeConfiguration<Apontamento>
    {
        public void Configure(EntityTypeBuilder<Apontamento> builder)
        {
            builder.Property(x => x.Descricao).IsRequired();
            builder.Property(x => x.Data).IsRequired();
        }
    }
}
