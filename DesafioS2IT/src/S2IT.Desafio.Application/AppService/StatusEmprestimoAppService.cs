using AutoMapper;
using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Application.ViewModels;
using S2IT.Desafio.Domain.Entities;
using S2IT.Desafio.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.AppService
{
    public class StatusEmprestimoAppService : IStatusEmprestimoAppService
    {
        private readonly IStatusEmprestimoRepository _repository;

        public StatusEmprestimoAppService(IStatusEmprestimoRepository repository)
        {
            _repository = repository;
        }

        public StatusEmprestimoViewModel Adicionar(StatusEmprestimoViewModel obj)
        {
            throw new NotImplementedException();
        }

        public StatusEmprestimoViewModel Atualizar(StatusEmprestimoViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public StatusEmprestimoViewModel Excluir(Expression<Func<StatusEmprestimoViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReturnModel Obter<ReturnModel>(Expression<Func<StatusEmprestimoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<StatusEmprestimoViewModel, bool>>, Expression<Func<StatusEmprestimo, bool>>>(predicate);

            return Mapper.Map<StatusEmprestimo, ReturnModel>(_repository.Obter(mappedPredicate));
        }

        public IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<StatusEmprestimoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<StatusEmprestimoViewModel, bool>>, Expression<Func<StatusEmprestimo, bool>>>(predicate);

            return Mapper.Map<IEnumerable<StatusEmprestimo>, IEnumerable<ReturnModel>>(_repository.ObterLista(mappedPredicate));
        }
    }
}
