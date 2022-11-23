using Eleicao.Data.Repositories.Eleicao;
using Eleicao.Dominio.Eleicao.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao.IoC.App_Start
{
    public static class InjectionDependencyCore
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            AddRepositories(services);
        }

        private static void AddApplication(IServiceCollection services)
        {
        }

        private static void AddServices(IServiceCollection services)
        {
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IEleicaoRepository, EleicaoRepository>();
        }
    }
}
