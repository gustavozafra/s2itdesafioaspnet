using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity obj);

        TEntity Atualizar(TEntity obj);

        TEntity Excluir(TEntity obj);

        void Dispose();
    }
}
