using S2IT.Desafio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Infra.Data.EntityConfig
{
    public class StatusEmprestimoConfiguration : EntityTypeConfiguration<StatusEmprestimo>
    {
        public StatusEmprestimoConfiguration()
        {
            HasKey(p => p.IdStatusEmprestimo);

            Property(p => p.IdStatusEmprestimo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Descricao)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
