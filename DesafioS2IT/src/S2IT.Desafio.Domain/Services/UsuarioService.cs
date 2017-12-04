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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario Adicionar(Usuario obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Adicionar(obj);
        }

        public Usuario Atualizar(Usuario obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Usuario Excluir(Usuario obj)
        {
            //Alguma validação de Regra de Negócio aqui
            return _repository.Excluir(obj);
        }
    }
}
