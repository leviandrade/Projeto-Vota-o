using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Acesso.Entidades
{
    public class TipoUsuarioPermissaoEntity : Entidade
    {
        public TipoUsuarioPermissaoEntity(Guid id, Guid idTipoUsuario, Guid idPermissao)
        {
            Id = id;
            IdTipoUsuario = idTipoUsuario;
            IdPermissao = idPermissao;
        }

        protected TipoUsuarioPermissaoEntity() { }
        public Guid IdTipoUsuario { get; private set; }
        public Guid IdPermissao { get; set; }
        public PermissaoEntity Permissao { get; set; }
    }
}
