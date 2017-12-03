using AutoMapper;
using S2IT.Desafio.Application.ViewModels;
using S2IT.Desafio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => {

                //DomainModel to ViewModel
                cfg.CreateMap<UsuarioViewModel, Usuario>();
                //ViewModel to DomainModel
                cfg.CreateMap<Usuario, UsuarioViewModel>();

                //DomainModel to ViewModel
                cfg.CreateMap<AmigoViewModel, Amigo>();
                //ViewModel to DomainModel
                cfg.CreateMap<Amigo, AmigoViewModel>();

                //DomainModel to ViewModel
                cfg.CreateMap<JogoViewModel, Jogo>();
                //ViewModel to DomainModel
                cfg.CreateMap<Jogo, JogoViewModel>();

                //DomainModel to ViewModel
                cfg.CreateMap<EmprestimoViewModel, Emprestimo>();
                //ViewModel to DomainModel
                cfg.CreateMap<Emprestimo, EmprestimoViewModel>();

                //DomainModel to ViewModel
                cfg.CreateMap<StatusEmprestimoViewModel, StatusEmprestimo>();
                //ViewModel to DomainModel
                cfg.CreateMap<StatusEmprestimo, StatusEmprestimoViewModel>();
            });
        }
    }
}
