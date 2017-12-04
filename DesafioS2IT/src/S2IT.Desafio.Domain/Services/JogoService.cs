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
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _repository;

        public JogoService(IJogoRepository repository)
        {
            _repository = repository;
        }

        public Jogo Adicionar(Jogo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Adicionar(obj);
        }

        public Jogo Atualizar(Jogo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Jogo Excluir(Jogo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Excluir(obj);
        }
    }
}
