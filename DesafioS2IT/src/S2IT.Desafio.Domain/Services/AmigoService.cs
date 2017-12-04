using S2IT.Desafio.Domain.Entities;
using S2IT.Desafio.Domain.Interfaces.Repository;
using S2IT.Desafio.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Services
{
    public class AmigoService : IAmigoService
    {
        private readonly IAmigoRepository _repository;

        public AmigoService(IAmigoRepository repository)
        {
            _repository = repository;
        }

        public Amigo Adicionar(Amigo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Adicionar(obj);
        }

        public Amigo Atualizar(Amigo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Amigo Excluir(Amigo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Excluir(obj);
        }
    }
}
