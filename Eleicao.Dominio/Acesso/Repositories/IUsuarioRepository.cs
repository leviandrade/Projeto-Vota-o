using Eleicao.Dominio.Acesso.Entidades;
using Eleicao.Dominio.Interfaces;

namespace Eleicao.Dominio.Acesso.Repositories
{
    public interface IUsuarioRepository : IRepository<UsuarioEntity>
    {
        Task<UsuarioEntity> ObterUsuario(string cpf, string senha);
    }
}
