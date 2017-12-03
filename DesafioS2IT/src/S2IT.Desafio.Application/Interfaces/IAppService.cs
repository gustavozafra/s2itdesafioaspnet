using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.Interfaces
{
    public interface IAppService<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity obj);

        TEntity Atualizar(TEntity obj);

        TEntity Excluir(Expression<Func<TEntity, bool>> predicate);

        ReturnModel Obter<ReturnModel>(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<TEntity, bool>> predicate);

        void Dispose();
    }
}
