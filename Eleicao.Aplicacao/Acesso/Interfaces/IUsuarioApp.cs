using Eleicao.DTL.Acesso;

namespace Eleicao.Aplicacao.Acesso.Interfaces
{
    public interface IUsuarioApp
    {
        Task<IEnumerable<UsuarioDTO>> Listar();
    }
}
