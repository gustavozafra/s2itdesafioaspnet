using S2IT.Desafio.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using S2IT.Desafio.Infra.Data.Context;
using System.Data.Entity;

namespace S2IT.Desafio.Infra.Data.Repository
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        private readonly DesafioS2ITContext Db;
        public Repository()
        {
            Db = new DesafioS2ITContext();
        }

        public TEntity Adicionar(TEntity obj)
        {
            var addModel = Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
            return addModel;
        }

        public TEntity Atualizar(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();

            return obj;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity Excluir(TEntity obj)
        {
            var deleteModel = Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();

            return deleteModel;
        }

        public TEntity Obter(Expression<Func<TEntity, bool>> predicate)
        {
            return Db.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        public IEnumerable<TEntity> ObterLista(Expression<Func<TEntity, bool>> predicate)
        {
            return Db.Set<TEntity>().Where(predicate);
        }
    }
}
