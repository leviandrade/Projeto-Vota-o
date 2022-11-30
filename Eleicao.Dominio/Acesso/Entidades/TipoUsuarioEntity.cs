using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Acesso.Entidades
{
    public class TipoUsuarioEntity : Entidade
    {
        public TipoUsuarioEntity(Guid id, string nmTipoUsuario)
        {
            Id = id;
            NmTipoUsuario = nmTipoUsuario;
        }

        protected TipoUsuarioEntity() { }
        public string NmTipoUsuario { get; private set; }
        public ICollection<TipoUsuarioPermissaoEntity> TipoUsuarioPermissao { get; set; }
    }
}
