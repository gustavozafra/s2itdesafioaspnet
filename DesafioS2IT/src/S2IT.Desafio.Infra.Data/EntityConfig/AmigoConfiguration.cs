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
    public class AmigoConfiguration : EntityTypeConfiguration<Amigo>
    {
        public AmigoConfiguration()
        {
            HasKey(p => p.IdAmigo);

            Property(p => p.IdAmigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Telefone)
                .HasMaxLength(50)
                .IsOptional();

            Property(p => p.DataNascimento)
                .IsRequired();
        }
    }
}
