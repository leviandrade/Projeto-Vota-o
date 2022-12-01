using Eleicao.API.Extensions;
using Eleicao.Aplicacao.Acesso.Interfaces;
using Eleicao.DTL.Acesso;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eleicao.API.Controllers.Acesso
{
    [Authorize]
    [ApiController]
    [Route("Acesso/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApp _usuarioApp;

        public UsuarioController(IUsuarioApp usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        [ClaimsAuthorize("Usuario", "Listar")]
        [HttpGet]
        public async Task<IEnumerable<UsuarioDTO>> Get()
        {
            return await _usuarioApp.Listar();
        }
    }
}
