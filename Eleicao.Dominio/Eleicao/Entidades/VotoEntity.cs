using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Eleicao.Entidades
{
    public class VotoEntity : Entidade
    {
        public Guid IdEleicaoCandidato { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
