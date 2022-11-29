using AutoMapper;
using Eleicao.Aplicacao.Acesso.Interfaces;
using Eleicao.Dominio.Acesso.Repositories;
using Eleicao.DTL.Acesso;

namespace Eleicao.Aplicacao.Acesso
{
    public sealed class UsuarioApp : IUsuarioApp
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioApp(IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsuarioDTO>> Listar()
        {
            var lstUsuarioEntity = await _usuarioRepository.Listar();
            return _mapper.Map<IEnumerable<UsuarioDTO>>(lstUsuarioEntity);
        }
    }
}
