using S2IT.Desafio.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Services
{
    public class Service<TEntity> : IDisposable, IService<TEntity> where TEntity : class
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

        public TEntity Excluir(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
