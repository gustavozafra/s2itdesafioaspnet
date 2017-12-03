using S2IT.Desafio.Domain.Entities;
using S2IT.Desafio.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Infra.Data.Context
{
    public class DesafioS2ITContext : DbContext
    {
        public DesafioS2ITContext()
            : base("DesafioS2IT")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<StatusEmprestimo> StatusEmprestimo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new AmigoConfiguration());
            modelBuilder.Configurations.Add(new JogoConfiguration());
            modelBuilder.Configurations.Add(new EmprestimoConfiguration());
            modelBuilder.Configurations.Add(new StatusEmprestimoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("FlagAtivo") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("FlagAtivo").CurrentValue = true;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DataModificacao") != null))
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
