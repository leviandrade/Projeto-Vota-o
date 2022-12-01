namespace Eleicao.DTL.Acesso
{
    public class UsuarioPermissaoDTO
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdPermissao { get; set; }
        public PermissaoDTO Permissao { get; set; }
    }
}
