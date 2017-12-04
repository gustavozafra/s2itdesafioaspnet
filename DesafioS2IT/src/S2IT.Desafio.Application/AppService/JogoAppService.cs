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
    public class JogoAppService : IJogoAppService
    {
        private readonly IJogoRepository _repository;
        private readonly IJogoService _service;

        public JogoAppService(IJogoRepository repository, IJogoService service)
        {
            _repository = repository;
            _service = service;
        }

        public JogoViewModel Adicionar(JogoViewModel obj)
        {
            var mappedModel = Mapper.Map<JogoViewModel, Jogo>(obj);

            var addedModel = _service.Adicionar(mappedModel);

            return Mapper.Map<Jogo, JogoViewModel>(addedModel);
        }

        public JogoViewModel Atualizar(JogoViewModel obj)
        {
            var mappedModel = Mapper.Map<JogoViewModel, Jogo>(obj);

            var updateModel = _service.Atualizar(mappedModel);

            return Mapper.Map<Jogo, JogoViewModel>(updateModel);
        }

        public void Dispose()
        {
            _repository.Dispose();
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public JogoViewModel Excluir(Expression<Func<JogoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<JogoViewModel, bool>>, Expression<Func<Jogo, bool>>>(predicate);

            var mapperModel = _repository.Obter(mappedPredicate);

            return Mapper.Map<Jogo, JogoViewModel>(_service.Excluir(mapperModel));
        }

        public ReturnModel Obter<ReturnModel>(Expression<Func<JogoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<JogoViewModel, bool>>, Expression<Func<Jogo, bool>>>(predicate);

            return Mapper.Map<Jogo, ReturnModel>(_repository.Obter(mappedPredicate));
        }

        public IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<JogoViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<JogoViewModel, bool>>, Expression<Func<Jogo, bool>>>(predicate);

            var result = _repository.ObterLista(mappedPredicate);

            return Mapper.Map<IEnumerable<Jogo>, IEnumerable<ReturnModel>>(result);
        }
    }
}
