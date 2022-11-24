using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Eleicao.Entidades
{
    public class VotoEntity : Entidade
    {
        public int IdEleicaoCandidato { get; set; }
        public int IdUsuario { get; set; }
    }
}
