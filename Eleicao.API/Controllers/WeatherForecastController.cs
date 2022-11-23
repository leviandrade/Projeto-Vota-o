using Eleicao.Dominio.Eleicao.Entidades;
using Eleicao.Dominio.Eleicao.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eleicao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IEleicaoRepository _eleicaoRepository;

        public WeatherForecastController(IEleicaoRepository eleicaoRepository)
        {
            _eleicaoRepository = eleicaoRepository;
        }

        [HttpGet(Name = "Listar")]
        public async Task<IEnumerable<EleicaoEntity>> Get()
        {
            return await _eleicaoRepository.Listar();
        }
    }
}