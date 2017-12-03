using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity obj);

        TEntity Atualizar(TEntity obj);

        TEntity Excluir(TEntity obj);

        TEntity Obter(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> ObterLista(Expression<Func<TEntity, bool>> predicate);

        void Dispose();
    }
}
