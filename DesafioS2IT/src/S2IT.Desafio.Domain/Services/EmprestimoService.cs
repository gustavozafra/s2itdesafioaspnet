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
    public class EmprestimoService : IEmprestimoService
    {
        private readonly IEmprestimoRepository _repository;

        public EmprestimoService(IEmprestimoRepository repository)
        {
            _repository = repository;
        }

        public Emprestimo Adicionar(Emprestimo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Adicionar(obj);
        }

        public Emprestimo Atualizar(Emprestimo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Emprestimo Excluir(Emprestimo obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Excluir(obj);
        }
    }
}
