using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using S2IT.Desafio.Domain.Interfaces.Repository;
using S2IT.Desafio.Domain.Interfaces.Services;
using AutoMapper;
using S2IT.Desafio.Domain.Entities;

namespace S2IT.Desafio.Application.AppService
{
    public class AmigoAppService : IAmigoAppService
    {
        private readonly IAmigoRepository _repository;
        private readonly IAmigoService _service;

        public AmigoAppService(IAmigoRepository repository, IAmigoService service)
        {
            _repository = repository;
            _service = service;
        }

        public AmigoViewModel Adicionar(AmigoViewModel obj)
        {
            var mappedModel = Mapper.Map<AmigoViewModel, Amigo>(obj);

            var addedModel = _service.Adicionar(mappedModel);

            return Mapper.Map<Amigo, AmigoViewModel>(addedModel);
        }

        public AmigoViewModel Atualizar(AmigoViewModel obj)
        {
            var mappedModel = Mapper.Map<AmigoViewModel, Amigo>(obj);

            var updateModel = _service.Atualizar(mappedModel);

            return Mapper.Map<Amigo, AmigoViewModel>(updateModel);
        }

        public void Dispose()
        {
            _repository.Dispose();
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public AmigoViewModel Excluir(Expression<Func<AmigoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<AmigoViewModel, bool>>, Expression<Func<Amigo, bool>>>(predicate);

            var mapperModel = _repository.Obter(mappedPredicate);

            return Mapper.Map<Amigo, AmigoViewModel>(_service.Excluir(mapperModel));
        }

        public ReturnModel Obter<ReturnModel>(Expression<Func<AmigoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<AmigoViewModel, bool>>, Expression<Func<Amigo, bool>>>(predicate);

            return Mapper.Map<Amigo, ReturnModel>(_repository.Obter(mappedPredicate));
        }

        public IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<AmigoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<AmigoViewModel, bool>>, Expression<Func<Amigo, bool>>>(predicate);

            var result = _repository.ObterLista(mappedPredicate);

            return Mapper.Map<IEnumerable<Amigo>, IEnumerable<ReturnModel>>(result);
        }
    }
}
