using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Acesso.Entidades
{
    public class PermissaoEntity : Entidade
    {
        public PermissaoEntity(Guid id, string nmClaim, string claimValue)
        {
            Id = id;
            NmClaim = nmClaim;
            ClaimValue = claimValue;
        }

        protected PermissaoEntity() { }
        public string NmClaim { get; private set; }
        public string ClaimValue { get; set; }
    }
}
