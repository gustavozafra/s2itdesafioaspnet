using S2IT.Desafio.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace S2IT.Desafio.Application.AppService
{
    public class AppService<TEntity> : IDisposable, IAppService<TEntity> where TEntity : class
    {
        public TEntity Adicionar(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public TEntity Atualizar(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity Excluir(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReturnModel Obter<ReturnModel>(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
