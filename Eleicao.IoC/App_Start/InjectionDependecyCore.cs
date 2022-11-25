using Eleicao.Data.Repositories.Acesso;
using Eleicao.Data.Repositories.Eleicao;
using Eleicao.Dominio.Acesso.Repositories;
using Eleicao.Dominio.Eleicao.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IEleicaoRepository, EleicaoRepository>();
            services.AddScoped<IVotoRepository, VotoRepository>();
        }
    }
}
