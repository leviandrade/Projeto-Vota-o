using Eleicao.Data.Contexts;
using Eleicao.Dominio.Acesso.Entidades;
using Eleicao.Dominio.Acesso.Repositories;

namespace Eleicao.Data.Repositories.Acesso
{
    public sealed class UsuarioRepository : Repository<UsuarioEntity, EleicaoContext>, IUsuarioRepository
    {
        public UsuarioRepository(EleicaoContext context) : base(context)
        {
        }
    }
}
