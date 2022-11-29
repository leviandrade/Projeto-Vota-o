using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Eleicao.Entidades
{
    public class EleicaoCandidatoEntity : Entidade
    {
        public Guid IdEleicao { get; set; }
        public Guid IdCandidato { get; set; }
    }
}
