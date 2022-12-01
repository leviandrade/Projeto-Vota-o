using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Acesso.Entidades
{
    public class UsuarioPermissaoEntity : Entidade
    {
        public UsuarioPermissaoEntity(Guid id, Guid idUsuario, Guid idPermissao)
        {
            Id = id;
            IdUsuario = idUsuario;
            IdPermissao = idPermissao;
        }

        protected UsuarioPermissaoEntity() { }
        public Guid IdUsuario { get; private set; }
        public Guid IdPermissao { get; set; }
        public PermissaoEntity Permissao { get; set; }
    }
}
