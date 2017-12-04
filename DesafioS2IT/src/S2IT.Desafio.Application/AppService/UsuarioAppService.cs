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
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IUsuarioService _service;

        public UsuarioAppService(IUsuarioRepository repository, IUsuarioService service)
        {
            _repository = repository;
            _service = service;
        }

        public UsuarioViewModel Adicionar(UsuarioViewModel obj)
        {
            var mappedModel = Mapper.Map<UsuarioViewModel, Usuario>(obj);

            var addedModel = _service.Adicionar(mappedModel);

            return Mapper.Map<Usuario, UsuarioViewModel>(addedModel);
        }

        public UsuarioViewModel Atualizar(UsuarioViewModel obj)
        {
            var mappedModel = Mapper.Map<UsuarioViewModel, Usuario>(obj);

            var updateModel = _service.Atualizar(mappedModel);

            return Mapper.Map<Usuario, UsuarioViewModel>(updateModel);
        }

        public void Dispose()
        {
            _repository.Dispose();
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public UsuarioViewModel Excluir(Expression<Func<UsuarioViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<UsuarioViewModel, bool>>, Expression<Func<Usuario, bool>>>(predicate);

            var mapperModel = _repository.Obter(mappedPredicate);

            return Mapper.Map<Usuario, UsuarioViewModel>(_service.Excluir(mapperModel));
        }

        public ReturnModel Obter<ReturnModel>(Expression<Func<UsuarioViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<UsuarioViewModel, bool>>, Expression<Func<Usuario, bool>>>(predicate);

            return Mapper.Map<Usuario, ReturnModel>(_repository.Obter(mappedPredicate));
        }

        public IEnumerable<ReturnModel> ObterLista<ReturnModel>(Expression<Func<UsuarioViewModel, bool>> predicate)
        {
            var mappedPredicate = Mapper.Map<Expression<Func<UsuarioViewModel, bool>>, Expression<Func<Usuario, bool>>>(predicate);

            var result = _repository.ObterLista(mappedPredicate);

            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<ReturnModel>>(result);
        }
    }
}
