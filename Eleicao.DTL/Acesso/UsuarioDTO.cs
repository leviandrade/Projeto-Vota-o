namespace Eleicao.DTL.Acesso
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string NmUsuario { get; set; }
        public string NrCpf { get; set; }
        public string Senha { get; set; }
        public Guid IdTipoUsuario { get; set; }

        public TipoUsuarioDTO TipoUsuario { get; set; }
    }
}
