using Eleicao.Data.Contexts;
using Eleicao.Dominio.Eleicao.Entidades;
using Eleicao.Dominio.Eleicao.Repositories.Interfaces;

namespace Eleicao.Data.Repositories.Eleicao
{
    public sealed class VotoRepository : Repository<VotoEntity, EleicaoContext>, IVotoRepository
    {
        public VotoRepository(EleicaoContext context) : base(context)
        {
        }
    }
}
