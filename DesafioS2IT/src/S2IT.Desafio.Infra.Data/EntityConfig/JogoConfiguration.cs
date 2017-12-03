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
    public class JogoConfiguration : EntityTypeConfiguration<Jogo>
    {
        public JogoConfiguration()
        {
            HasKey(p => p.IdJogo);

            Property(p => p.IdJogo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
