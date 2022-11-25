using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Eleicao.Entidades
{
    public class EleicaoEntity : Entidade
    {
        public EleicaoEntity(Guid id, string nmEleicao, DateTime dtInicioEleicao, DateTime dtTerminoEleicao)
        {
            Id = id;
            NmEleicao = nmEleicao;
            DtInicioEleicao = dtInicioEleicao;
            DtTerminoEleicao = dtTerminoEleicao;
        }

        protected EleicaoEntity() { }
        public string NmEleicao { get; private set; }
        public DateTime DtInicioEleicao { get; private set; }
        public DateTime DtTerminoEleicao { get; private set; }

    }
}
