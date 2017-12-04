using S2IT.Desafio.Application.AppService;
using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Domain.Interfaces.Repository;
using S2IT.Desafio.Domain.Interfaces.Services;
using S2IT.Desafio.Domain.Services;
using S2IT.Desafio.Infra.Data.Context;
using S2IT.Desafio.Infra.Data.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Infra.CrossCutting.IoC
{
    public class Bootstrapper
    {
        public static void Register(Container container)
        {
            container.Register<DesafioS2ITContext>(Lifestyle.Scoped);

            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IJogoRepository, JogoRepository>(Lifestyle.Scoped);
            container.Register<IAmigoRepository, AmigoRepository>(Lifestyle.Scoped);
            container.Register<IEmprestimoRepository, EmprestimoRepository>(Lifestyle.Scoped);
            container.Register<IStatusEmprestimoRepository, StatusEmprestimoRepository>(Lifestyle.Scoped);

            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            container.Register<IJogoService, JogoService>(Lifestyle.Scoped);
            container.Register<IAmigoService, AmigoService>(Lifestyle.Scoped);
            container.Register<IEmprestimoService, EmprestimoService>(Lifestyle.Scoped);

            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<IJogoAppService, JogoAppService>(Lifestyle.Scoped);
            container.Register<IAmigoAppService, AmigoAppService>(Lifestyle.Scoped);
            container.Register<IEmprestimoAppService, EmprestimoAppService>(Lifestyle.Scoped);
            container.Register<IStatusEmprestimoAppService, StatusEmprestimoAppService>(Lifestyle.Scoped);
        }
    }
}
