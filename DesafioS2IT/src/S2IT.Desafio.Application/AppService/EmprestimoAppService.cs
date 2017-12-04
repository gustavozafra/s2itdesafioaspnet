using AutoMapper;
using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Application.ViewModels;
using S2IT.Desafio.Domain.Entities;
using S2IT.Desafio.Domain.Interfaces.Repository;
using S2IT.Desafio.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.AppService
{
    public class EmprestimoAppService : IEmprestimoAppService
    {
        private readonly IEmprestimoRepository _repository;
        private readonly IEmprestimoService _service;

        public EmprestimoAppService(IEmprestimoRepository repository, IEmprestimoService service)
        {
            _repository = repository;
            _service = service;
        }

        public EmprestimoViewModel Adicionar(EmprestimoViewModel obj)
        {
            var mappedModel = Mapper.Map<EmprestimoViewModel, Emprestimo>(obj);

            var addedModel = _service.Adicionar(mappedModel);

            return Mapper.Map<Emprestimo, EmprestimoViewModel>(addedModel);
        }

        public EmprestimoViewModel Atualizar(EmprestimoViewModel obj)
        {
            var mappedModel = Mapper.Map<EmprestimoViewModel, Emprestimo>(obj);

            var updateModel = _service.Atualizar(mappedModel);

            return Mapper.Map<Emprestimo, EmprestimoViewModel>(updateModel);
        }

        public void Dispose()
        {
            _repository.Dispose();
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public EmprestimoViewModel Excluir(Expression<Func<EmprestimoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<EmprestimoViewModel, bool>>, Expression<Func<Emprestimo, bool>>>(predicate);

            var mapperModel = _repository.Obter(mappedPredicate);

            return Mapper.Map<Emprestimo, EmprestimoViewModel>(_service.Excluir(mapperModel));
        }

        public ReturnModel Obter<ReturnModel>(Expression<Func<EmprestimoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<EmprestimoViewModel, bool>>, Expression<Func<Emprestimo, bool>>>(predicate);

            return Mapper.Map<Emprestimo, ReturnModel>(_repository.Obter(mappedPredicate));
        }

        public IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<EmprestimoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<EmprestimoViewModel, bool>>, Expression<Func<Emprestimo, bool>>>(predicate);

            var result = _repository.ObterLista(mappedPredicate);

            return Mapper.Map<IEnumerable<Emprestimo>, IEnumerable<ReturnModel>>(result);
        }
    }
}
