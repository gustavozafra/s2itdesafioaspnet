using S2IT.Desafio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(p => p.IdUsuario);

            Property(p => p.IdUsuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Login)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            Property(p => p.Senha)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Email)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Telefone)
                .HasMaxLength(50)
                .IsOptional();
        }
    }
}
