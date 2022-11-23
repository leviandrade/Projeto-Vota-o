using Eleicao.Dominio.Eleicao.Entidades;
using Eleicao.Dominio.Interfaces;

namespace Eleicao.Dominio.Eleicao.Repositories.Interfaces
{
    public interface IEleicaoRepository : IRepository<EleicaoEntity>
    {
        Task<List<EleicaoEntity>> Listar();
    }
}
