using Eleicao.Dominio.EntidadeBase;

namespace Eleicao.Dominio.Acesso.Entidades
{
    public class UsuarioEntity : Entidade
    {
        public UsuarioEntity(string nmUsuario, string nrCpf, string senha, Guid idTipoUsuario)
        {
            NmUsuario = nmUsuario;
            NrCpf = nrCpf;
            Senha = senha;
            IdTipoUsuario = idTipoUsuario;
        }
        public UsuarioEntity()
        {
        }
        public string NmUsuario { get; private set; }
        public string NrCpf { get; private set; }
        public string Senha { get; private set; }
        public Guid IdTipoUsuario { get; private set; }

        public TipoUsuarioEntity TipoUsuario { get; private set; }

    }
}
