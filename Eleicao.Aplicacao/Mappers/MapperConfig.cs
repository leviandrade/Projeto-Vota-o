using AutoMapper;
using Eleicao.Dominio.Acesso.Entidades;
using Eleicao.Dominio.Eleicao.Entidades;
using Eleicao.DTL.Acesso;
using Eleicao.DTL.Eleicao;

namespace Eleicao.Aplicacao.Mappers
{
    public class MapperConfig
    {
        public static IMapper RegisterMappers()
        {
            var config = new MapperConfiguration(cfg =>
            {
                ModuloAcesso(cfg);
                ModuloEleicao(cfg);
            });

            return config.CreateMapper();
        }
        private static void ModuloAcesso(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TipoUsuarioEntity, TipoUsuarioDTO>().ReverseMap();
            cfg.CreateMap<UsuarioEntity, UsuarioDTO>().ReverseMap();
            cfg.CreateMap<TipoUsuarioPermissaoEntity, TipoUsuarioPermissaoDTO>().ReverseMap();
            cfg.CreateMap<PermissaoEntity, PermissaoDTO>().ReverseMap();
        }
        private static void ModuloEleicao(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<EleicaoEntity, EleicaoDTO>().ReverseMap();
            cfg.CreateMap<EleicaoCandidatoEntity, EleicaoCandidatoDTO>().ReverseMap();
            cfg.CreateMap<VotoEntity, VotoDTO>().ReverseMap();
        }
    }
}
