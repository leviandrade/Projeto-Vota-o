using Eleicao.Data.Contexts;
using Eleicao.Dominio.Eleicao.Entidades;
using Eleicao.Dominio.Eleicao.Repositories.Interfaces;

namespace Eleicao.Data.Repositories.Eleicao
{
    public sealed class EleicaoRepository : Repository<EleicaoEntity, EleicaoContext>, IEleicaoRepository
    {
        public EleicaoRepository(EleicaoContext context) : base(context)
        {
        }     
    }
}
