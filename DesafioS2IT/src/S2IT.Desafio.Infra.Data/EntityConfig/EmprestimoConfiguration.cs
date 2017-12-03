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
    public class EmprestimoConfiguration : EntityTypeConfiguration<Emprestimo>
    {
        public EmprestimoConfiguration()
        {
            HasKey(p => p.IdEmprestimo);

            Property(p => p.IdEmprestimo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.DataEmprestimo)
                .IsRequired();

            Property(p => p.DataDevolucao)
                .IsOptional();
        }
    }
}
