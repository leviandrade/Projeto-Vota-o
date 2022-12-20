using Eleicao.API.Extensions;
using Eleicao.Aplicacao.Acesso.Interfaces;
using Eleicao.DTL.Acesso;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eleicao.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioApp _usuarioApp;

        public UsuariosController(IUsuarioApp usuarioApp)
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
