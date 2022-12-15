using Eleicao.Data.Contexts;
using Eleicao.Dominio.Acesso.Entidades;
using Eleicao.Dominio.Acesso.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Eleicao.Data.Repositories.Acesso
{
    public sealed class UsuarioRepository : Repository<UsuarioEntity, EleicaoContext>, IUsuarioRepository
    {
        public UsuarioRepository(EleicaoContext context) : base(context)
        {
        }

        public async Task<UsuarioEntity> ObterUsuario(string cpf, string senha)
        {
            return await Db.Usuario
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.NrCpf.Equals(cpf) && p.Senha.Equals(senha));
        }
    }
}
